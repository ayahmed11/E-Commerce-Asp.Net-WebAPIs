using Dtos.Cart;
using E_CommerceProject.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.Order
{
    public class PlaceOrderRequestDto
    {
        public List<OrderItemDto>? OrderItems { get; set; }
    }
}
