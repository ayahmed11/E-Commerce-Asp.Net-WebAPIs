using Dtos.Product;
using E_CommerceProject.DAL.Data.Models;
using E_CommerceProject.DAL.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dtos.Category;

namespace Managers.Categories
{
    public class CategoryManager : ICategoryManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<AddCategoryDto> GetAllCategories()
        {
            var categories = _unitOfWork.CategoryRepository.GetAll()
                      .Select(p => new AddCategoryDto
                      {
                          Name = p.Name,
                          Description = p.Description
                      });

            return categories;
        }
        public void AddCategory(AddCategoryDto addCategoryDto)
        {
            var category = _unitOfWork.CategoryRepository.GetByName(addCategoryDto.Name);
            if (category != null)
            {
                throw new ArgumentException($"This Category {addCategoryDto.Name} Is Already Exist");
            }
            var CategoryEntity = new Category
            {
                Name = addCategoryDto.Name,
                Description = addCategoryDto.Description,
            };
            _unitOfWork.CategoryRepository.Add(CategoryEntity);
            _unitOfWork.SaveChanges();
        }

    }
}
