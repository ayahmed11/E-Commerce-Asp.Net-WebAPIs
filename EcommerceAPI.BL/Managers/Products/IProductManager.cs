using E_CommerceProject.DAL.Data.Models;
using System.Collections.Generic;
using Dtos.Product;

namespace Managers.Products
{
    public interface IProductManager
    {
        IEnumerable<ProductReadDto> GetProducts(string? category, string? name);
        public ProductDetailsDto? GetById(int id);
        public void AddProduct(ProductDto product);
        public void DeleteProduct(int id);
        public void UpdateProduct(int id, ProductDto product);
    }
}
