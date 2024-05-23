using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using E_CommerceProject.DAL.Data.Models.Enums;
using Microsoft.AspNetCore.Identity;

namespace E_CommerceProject.DAL.Data.Models
{
    public class User : IdentityUser
    {
        public int Age { get; set; }
        public string Address { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public string UserRole { get; set; } = "User";
        public ICollection<Order> Orders { get; set; } = new List<Order>(); //1:M user to order 
        public int CartID { get; set; }//1:1 user to cart 
        public Cart? Cart { get; set; }
    }
}
