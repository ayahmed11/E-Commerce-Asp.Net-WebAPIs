using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_CommerceProject.DAL.Data.Models.Enums;

namespace E_CommerceProject.DAL.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public int Rate { get; set; }
        public string? ImageUrl { get; set; }
        public string Description { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        [Required]
        [MinLength(1)]
        public int Count { get; set; }
        [Required]
        public int CategoryId { get; set; }//M:1 product to category 
        public Category? Category { get; set; }  
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();//1:M product to cartitem
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();//1:M product to orderitem

    }
}
