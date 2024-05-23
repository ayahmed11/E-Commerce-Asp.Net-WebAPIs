using E_CommerceProject.DAL.Repositorries.Products;
using E_CommerceProject.DAL.Repositorries.Category;
using E_CommerceProject.DAL.Repositorries.Carts;
using E_CommerceProject.DAL.Repositorries.CartItems;
using E_CommerceProject.DAL.Repositorries.Orders;


namespace E_CommerceProject.DAL.UnitOfWorks;

public interface IUnitOfWork
{
    public ICartRepository CartRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IProductRepository ProductRepository { get; }
    public ICategoryRepository CategoryRepository { get; }
    public ICartItemRepository CartItemRepository { get; }

    void SaveChanges();
}
