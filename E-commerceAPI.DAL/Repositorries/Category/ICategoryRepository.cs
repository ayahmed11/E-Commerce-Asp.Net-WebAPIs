using E_CommerceProject.DAL.Repositorries.Generic;


namespace E_CommerceProject.DAL.Repositorries.Category
{
    public interface ICategoryRepository : IGenericRepository<Data.Models.Category>
    {
        public Data.Models.Category? GetByName(string name);
    }
}
