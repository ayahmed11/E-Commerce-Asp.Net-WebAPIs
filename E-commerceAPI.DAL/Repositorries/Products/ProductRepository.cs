using E_CommerceProject.DAL.Data.Models.Enums;
using E_CommerceProject.DAL.Data.Context;
using E_CommerceProject.DAL.Data.Models;
using E_CommerceProject.DAL.Repositorries.Generic;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace E_CommerceProject.DAL.Repositorries.Products
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ECommerceContext context) : base(context)
        {
        }

        public IEnumerable<Product> GetProducts(string? category, string? name)
        {
            var query = _context.Products.AsQueryable();

            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(p => p.Category!.Name == category);
            }

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.Name.Contains(name));
            }

            return query.ToList();
        }


    }
}
