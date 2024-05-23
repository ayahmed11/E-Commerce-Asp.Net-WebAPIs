using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_CommerceProject.DAL.Data.Models;
public class CartItem
{
    public int ID { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CartId { get; set; } //1:M cart to cartitem
    public Cart? Cart { get; set; } //Cart Navigation property 
    public int ProductId { get; set; } //1: M product to orderitem
    public Product? Product { get; set; } //Product Navigation property 
}
