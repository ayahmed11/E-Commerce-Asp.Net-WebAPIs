using E_CommerceProject.DAL.Repositorries.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceProject.DAL.Repositorries.CartItems
{
    public interface ICartItemRepository : IGenericRepository<CartItem>
    {
        public IEnumerable<CartItem> GetAllByCartId(int cartId);
    }
}
