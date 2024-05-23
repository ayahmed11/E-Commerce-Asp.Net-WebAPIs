using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.Cart
{
    public class CartDto
    {
        public int ID { get; set; }
        public string UserId { get; set; } = string.Empty;  //the cart of a specific user 
        public ICollection<CartItemDto> CartItems { get; set; } = new List<CartItemDto>();
    }
}
