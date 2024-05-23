using E_CommerceProject.DAL.Repositorries.Products;
using E_CommerceProject.DAL.Data.Context;
using E_CommerceProject.DAL.Repositorries.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceProject.DAL.Repositorries.Category
{
    public class CategoryRepository : GenericRepository<Data.Models.Category>, ICategoryRepository
    {
        public CategoryRepository(ECommerceContext context) : base(context)
        {
        }

        public Data.Models.Category? GetByName(string name)
        {
            return _context.Categories.FirstOrDefault(c => c.Name == name);
        }

    }
}
