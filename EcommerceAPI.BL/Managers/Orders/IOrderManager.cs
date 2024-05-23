using E_CommerceProject.DAL.Data.Models;
using E_CommerceProject.DAL.Repositorries.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dtos.Order;

namespace Managers.Orders
{
    public interface IOrderManager
    {
        void PlaceOrder(PlaceOrderRequestDto request);
        IEnumerable<OrderDto> GetOrderHistory();

    }
}
