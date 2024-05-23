using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceProject.DAL.Data.Models
{
    public class Order
    {
        public int ID { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedDateTime { get; set; }

        //HashSet:Efficient for add/remove operations and checking for existence of elements,Does not allow duplicates.
        public ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>(); //1:M order to orderitems 
        public string UserId { get; set; } = string.Empty; //1:M user to order 
        public User? User { get; set; }//Navigation property 
    }
}
