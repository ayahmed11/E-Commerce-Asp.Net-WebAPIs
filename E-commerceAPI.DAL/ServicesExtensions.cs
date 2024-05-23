using E_CommerceProject.DAL.Data.Context;
using E_CommerceProject.DAL.Repositorries.CartItems;
using E_CommerceProject.DAL.Repositorries.Carts;
using E_CommerceProject.DAL.Repositorries.Category;
using E_CommerceProject.DAL.Repositorries.Orders;
using E_CommerceProject.DAL.Repositorries.Products;
using E_CommerceProject.DAL.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace E_CommerceProject.DAL
{
    public static class ServicesExtensions
    {
        public static void AddDALServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("E-CommerceDb");
            services.AddDbContext<ECommerceContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICartItemRepository, CartItemRepository>();


            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
