using E_CommerceProject.DAL.Data.Models;
using E_CommerceProject.DAL.UnitOfWorks;
using Microsoft.AspNetCore.Http;
using Dtos.Product;

namespace Managers.Products
{
    public class ProductManager : IProductManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public ProductDetailsDto GetById(int id)
        {
            var product = _unitOfWork.ProductRepository.GetById(id);
            if (product == null)
            {
                throw new ArgumentException($"Product With Id:{id} Not Found");
            }

            var category = _unitOfWork.CategoryRepository.GetById(product.CategoryId);
            var categoryName = category != null ? category.Name : "Unknown";

            return new ProductDetailsDto
            {
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                ImageFile = product.ImageUrl,
                CategoryName = categoryName,
                Rate = product.Rate,
                Count = product.Count
            };
        }

        public void AddProduct(ProductDto productDto)
        {
            var category = _unitOfWork.CategoryRepository.GetByName(productDto.CategoryName);
            if (category == null)
            {
                throw new ArgumentException("Category Not Found");
            }

            var productEntity = new Product
            {
                Name = productDto.ProductName,
                Price = productDto.Price,
                Description = productDto.Description,
                ImageUrl = UploadImage(productDto.ImageFile!),
                CategoryId = category.Id,
                Rate = productDto.Rate
            };

            _unitOfWork.ProductRepository.Add(productEntity);
            _unitOfWork.SaveChanges();

        }


        public void DeleteProduct(int id)
        {
            var product = _unitOfWork.ProductRepository.GetById(id);
            if (product == null)
            {
                throw new ArgumentException($"Product With Id:{id} Not Found");
            }

            _unitOfWork.ProductRepository.Delete(product);
            _unitOfWork.SaveChanges();

        }

        public IEnumerable<ProductReadDto> GetProducts(string? categoryName, string? productName)
        {
            var products = _unitOfWork.ProductRepository.GetProducts(categoryName, productName)
                       .Select(p => new ProductReadDto
                       {
                           Id = p.Id,
                           Name = p.Name,
                           Rate = p.Rate,
                           Image = p.ImageUrl!,
                           CategoryName = _unitOfWork.CategoryRepository.GetById(p.CategoryId)?.Name ?? "Unknown",
                           Price = p.Price
                       });

            return products;
        }

        public void UpdateProduct(int id, ProductDto productDto)
        {
            var existingProduct = _unitOfWork.ProductRepository.GetById(id);
            if (existingProduct == null)
            {
                throw new ArgumentException($"Product With Id:{id} Not Found");
            }
            var category = _unitOfWork.CategoryRepository.GetByName(productDto.CategoryName);
            if (category == null)
            {
                throw new ArgumentException("Category Not Found");
            }

            existingProduct.Name = productDto.ProductName;
            existingProduct.Price = productDto.Price;
            existingProduct.Description = productDto.Description;
            existingProduct.ImageUrl = UploadImage(productDto.ImageFile!);
            existingProduct.CategoryId = category.Id;
            existingProduct.Rate = productDto.Rate;
            _unitOfWork.ProductRepository.Update(existingProduct);
            _unitOfWork.SaveChanges();
        }

        private string UploadImage(IFormFile? imageFile)
        {
            if (imageFile == null || imageFile.Length == 0)
            {
                return string.Empty;
            }
            string[] allowedExtensions = new string[] { ".jpg", ".svg", ".png" };
            var fileExtensions = Path.GetExtension(imageFile.FileName);
            if (!allowedExtensions.Contains(fileExtensions))
            {
                throw new ArgumentException("Invalid File Format. Allowed Formats are: .jpg, .svg, .png");
            }

            var fileName = Guid.NewGuid().ToString() + fileExtensions;

            var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Assets", "images");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            var filePath = Path.Combine(directoryPath, fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                imageFile.CopyTo(fileStream);
            }

            return fileName;
        }
    }
}
