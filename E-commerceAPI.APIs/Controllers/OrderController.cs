using Dtos.Order;
using Managers.Orders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace E_CommerceProject.APIs.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderManager _orderManager;

        public OrderController(IOrderManager orderManager)
        {
            _orderManager = orderManager;
        }


        [Authorize]
        [HttpPost("PlacAnOrder")]
        public ActionResult PlaceOrder([FromBody] PlaceOrderRequestDto request)
        {
            try
            {
                _orderManager.PlaceOrder(request);
                return Ok("Order Placed Successflly !");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        
        [Authorize]
        [HttpGet("OrderHistory")]
        public ActionResult GetOrderHistory()
        {
            try
            {
                IEnumerable<OrderDto> orderHistory = _orderManager.GetOrderHistory();
                return Ok(orderHistory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
