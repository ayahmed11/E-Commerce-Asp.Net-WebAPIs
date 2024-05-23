using Managers.Carts;
using Managers.Categories;
using Managers.Orders;
using Managers.Products;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceProject.BL
{
    public static class ServicesExtensions
    {
        public static void AddBLServices(this IServiceCollection services)
        {
            services.AddScoped<IProductManager, ProductManager>();
            services.AddScoped<ICartManager, CartManager>();
            services.AddScoped<IOrderManager, OrderManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
        }
    }
}
