using Dtos.Cart;

namespace Managers.Carts
{
    public interface ICartManager
    {
        CartDto GetCart();
        void AddToCart(int productId, int quantity);
        void RemoveFromCart(int productId);
        void EditCartItemQuantity(int productId, int quantity);
        void ClearCart();

    }
}
