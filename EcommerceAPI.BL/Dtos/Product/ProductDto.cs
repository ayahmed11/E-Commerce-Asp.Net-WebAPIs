using Microsoft.AspNetCore.Http;


namespace Dtos.Product
{
    public class ProductDto
    {
        public string ProductName  { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Rate { get; set; }
        public IFormFile ImageFile { get; set; } = null!;
    }
}
