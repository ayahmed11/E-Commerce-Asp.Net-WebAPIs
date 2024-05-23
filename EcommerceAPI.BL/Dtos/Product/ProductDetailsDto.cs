using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.Product
{
    public class ProductDetailsDto
    {
        public string Name { get; set; } = null!;
        public int Rate { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public string CategoryName { get; set; } = null!;
        public string? ImageFile { get; set; } = string.Empty;
        public int Count { get; set; }
    }
}
