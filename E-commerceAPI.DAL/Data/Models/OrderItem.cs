using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceProject.DAL.Data.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public decimal PriceTotal { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public int OrderId { get; set; } //M:1 orderitem to order 
        public Order? Order { get; set; } //order navigation property 
        public int ProductId { get; set; } //M:1 orderitem to product  
        public Product? Product { get; set; }//product navigation property 

    }
}
