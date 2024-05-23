using Dtos.Cart;
using Microsoft.AspNetCore.Mvc;
using System;
using E_CommerceProject.DAL.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Managers.Carts;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceProject.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartManager _cartManager;

        public CartController(ICartManager cartManager)
        {
            _cartManager = cartManager;
        }

        [HttpGet]
        public ActionResult GetCart()
        {
            try
            {
                var cart = _cartManager.GetCart();
                return Ok(cart);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [Authorize]
        [HttpPost("{productId}/{quantity}")]
        public ActionResult AddToCart(int productId, int quantity)
        {
            try
            {
                _cartManager.AddToCart(productId, quantity);
                return Ok("Item Added Successfully");
            }
            catch (ArgumentException ex)
            {
                return BadRequest($"Error Adding Item To Cart: {ex.Message}");
            }
            catch (DbUpdateException dbEx)
            {
                var detailedError = dbEx.InnerException?.Message ?? dbEx.Message;
                return StatusCode(500, $"Internal Server Error: {detailedError}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }



        [Authorize]
        [HttpDelete("{productId}")]
        public ActionResult RemoveFromCart(int productId)
        {
            try
            {
                _cartManager.RemoveFromCart(productId);
                return Ok($"Product Of ID:{productId} Deleted From your Cart");
            }
            catch (ArgumentException ex)
            {
                return BadRequest($"Error Removing Item From Cart:{ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error:{ex.Message}");
            }
        }


        [Authorize]
        [HttpPut("{productId}/{quantity}")]
        public ActionResult EditCartItemQuantity(int productId, int quantity)
        {
            try
            {
                _cartManager.EditCartItemQuantity(productId, quantity);
                return Ok($"Done , The Quantity of product {productId} Updated Successfully");
            }
            catch (ArgumentException ex)
            {
                return BadRequest($"Error Editing Item Quantity In Cart: {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [Authorize]
        [HttpDelete]
        public ActionResult ClearCart()
        {
            try
            {
                _cartManager.ClearCart();
                return Ok($"Done! Cart Has Been Cleared");
            }
            catch (ArgumentException ex)
            {
                return BadRequest($"Error : {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
