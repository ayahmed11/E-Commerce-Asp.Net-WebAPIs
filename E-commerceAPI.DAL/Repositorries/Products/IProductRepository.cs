using E_CommerceProject.DAL.Data.Models;
using E_CommerceProject.DAL.Repositorries.Generic;
using System.Collections.Generic;

namespace E_CommerceProject.DAL.Repositorries.Products
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IEnumerable<Product> GetProducts(string? category, string? name);
    }
}
