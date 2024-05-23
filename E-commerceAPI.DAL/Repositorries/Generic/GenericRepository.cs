using E_CommerceProject.DAL.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceProject.DAL.Repositorries.Generic;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    protected readonly ECommerceContext _context;

    public GenericRepository(ECommerceContext context)
    {
        _context = context;
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _context.Set<TEntity>()
            .AsNoTracking();//to read the fetched data without making changes update add delete

    }

    public TEntity? GetById(int id)
    {
        return _context.Set<TEntity>()
            .Find(id);
    }

    public void Add(TEntity entity)
    {
        _context.Set<TEntity>()
            .Add(entity);
    }

    public void Delete(TEntity entity)
    {
        _context.Set<TEntity>()
            .Remove(entity);
    }

    public void Update(TEntity entity)
    {

    }
}
