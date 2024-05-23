using System.Security.Claims;
using Dtos.Order;
using E_CommerceProject.DAL.Data.Models;
using E_CommerceProject.DAL.UnitOfWorks;
using Microsoft.AspNetCore.Http;

namespace Managers.Orders
{
    public class OrderManager : IOrderManager
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public OrderManager(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        public void PlaceOrder(PlaceOrderRequestDto request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            string userId = GetUserId();
            if (string.IsNullOrEmpty(userId))
            {
                throw new InvalidOperationException("PLease Login First !");
            }

            var orderItems = new List<OrderItem>();

            foreach (var item in request.OrderItems!)
            {
                var product = _unitOfWork.ProductRepository.GetById(item.ProductId);
                if (product == null)
                {
                    throw new ArgumentException($"Product With ID:{item.ProductId} Not Found.");
                }

                if (product.Count < item.Quantity)
                {
                    throw new InvalidOperationException($"Insufficient stock for product ID {product.Name}. Available quantity: {product.Count}.");
                }

                orderItems.Add(new OrderItem
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    CreatedDate = DateTime.UtcNow,
                    PriceTotal = product.Price * item.Quantity
                });
                product.Count -= item.Quantity;
            }

            var order = new Order
            {
                UserId = userId,
                TotalPrice = CalculateTotalPrice(orderItems),
                CreatedDateTime = DateTime.UtcNow,
                OrderItems = orderItems
            };

            _unitOfWork.OrderRepository.PlaceOrder(order);
            _unitOfWork.SaveChanges();
        }

        public IEnumerable<OrderDto> GetOrderHistory()
        {
            string userId = GetUserId();
            if (string.IsNullOrEmpty(userId))
            {
                throw new InvalidOperationException("Please Login First !");
            }

            var orderHistory = _unitOfWork.OrderRepository.GetOrderHistory()
                .Where(o => o.UserId == userId)
                .Select(o => new OrderDto
                {
                    ID = o.ID,
                    TotalPrice = o.TotalPrice,
                    CreatedDateTime = o.CreatedDateTime
                })
                .ToList();

            return orderHistory;
        }

        private string GetUserId()
        {
            return _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value!;
        }


        private decimal CalculateTotalPrice(List<OrderItem> orderItems)
        {
            decimal totalPrice = 0;
            foreach (var orderItem in orderItems)
            {
                totalPrice += orderItem.PriceTotal;
            }
            return totalPrice;
        }
    }
}
