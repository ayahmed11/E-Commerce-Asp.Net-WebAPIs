using E_CommerceProject.DAL.Data.Models;

namespace E_CommerceProject.DAL.Repositorries.Generic;

public interface IGenericRepository<TEntity>where TEntity : class
{
    IEnumerable<TEntity> GetAll();
    TEntity? GetById(int id);
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
}
