using E_CommerceProject.DAL.Data.Context;
using E_CommerceProject.DAL.Repositorries.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceProject.DAL.Repositorries.CartItems
{
    public class CartItemRepository : GenericRepository<CartItem>, ICartItemRepository
    {
        public CartItemRepository(ECommerceContext context) : base(context)
        {
        }

        public IEnumerable<CartItem> GetAllByCartId(int cartId)
        {
            return _context.CartItems.Where(ci => ci.CartId == cartId).ToList();
        }
    }
}
