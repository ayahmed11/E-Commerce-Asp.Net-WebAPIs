using E_CommerceProject.DAL.Data.Models;
using E_CommerceProject.DAL.Repositorries.Generic;
using System.Collections.Generic;

namespace E_CommerceProject.DAL.Repositorries.Orders
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        public void PlaceOrder(Order order);
        IEnumerable<Order> GetOrderHistory();
    }
}
