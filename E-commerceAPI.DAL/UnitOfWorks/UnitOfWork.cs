using E_CommerceProject.DAL.Repositorries.Products;
using E_CommerceProject.DAL.Repositorries.Category;
using E_CommerceProject.DAL.Repositorries.Carts;
using E_CommerceProject.DAL.Repositorries.CartItems;
using E_CommerceProject.DAL.Repositorries.Orders;
using E_CommerceProject.DAL.Data.Context;

namespace E_CommerceProject.DAL.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{
    private readonly ECommerceContext _context;

    public ICartRepository CartRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IProductRepository ProductRepository { get; }
    public ICategoryRepository CategoryRepository { get; }
    public ICartItemRepository CartItemRepository { get; }

    public UnitOfWork(IProductRepository productRepository,
        IOrderRepository orderRepository,
        ICartRepository cartRepository,
        ICategoryRepository categoryRepository,
        ICartItemRepository cartItemRepository,
        ECommerceContext context)
    {
        ProductRepository = productRepository;
        OrderRepository = orderRepository;
        CartRepository = cartRepository;
        _context = context;
        CategoryRepository = categoryRepository;
        CartItemRepository = cartItemRepository;
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}
