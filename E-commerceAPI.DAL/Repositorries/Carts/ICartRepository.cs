using E_CommerceProject.DAL.Data.Models;
using E_CommerceProject.DAL.Repositorries.Generic;

namespace E_CommerceProject.DAL.Repositorries.Carts
{
    public interface ICartRepository : IGenericRepository<Cart>
    {
        public void AddToCart(int productId, int quantity);
        public void RemoveFromCart(int productId);
        public void EditCartItemQuantity(int productId, int quantity);
        public Product GetByProductId(int productId);
        public Cart GetByUserId(string userId);


    }
}
