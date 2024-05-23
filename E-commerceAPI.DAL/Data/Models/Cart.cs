using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceProject.DAL.Data.Models;
public class Cart
{
    public int ID { get; set; }
    public string UserId { get; set; } = string.Empty; //1 : 1 cart to user 
    public User? User { get; set; }// User Navigation property (Optional)
    public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>(); //1: M cart to cartitems 
}
