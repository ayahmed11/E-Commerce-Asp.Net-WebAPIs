using Dtos.Product;
using Dtos.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dtos.Category;

namespace Managers.Categories
{
    public interface ICategoryManager
    {
        IEnumerable<AddCategoryDto> GetAllCategories();
        void AddCategory(AddCategoryDto addCategoryDto);
    }
}
