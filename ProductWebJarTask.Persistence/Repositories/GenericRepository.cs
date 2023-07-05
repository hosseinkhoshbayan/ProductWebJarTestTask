using Microsoft.EntityFrameworkCore;
using ProductWebJarTask.Application.Contracts.Persistence;
using ProductWebJarTask.Persistence.Context;

namespace ProductWebJarTask.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly EShopWebjarTestTaskDbContext _context;

    public GenericRepository(EShopWebjarTestTaskDbContext context)
    {
        _context = context;
    }
    public async Task<T> Get(long id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<IReadOnlyList<T>> GetAll()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<bool> Exist(long id)
    {
        var entity = await Get(id);
        return entity != null;
    }

    public async Task<T> Add(T entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task Update(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }
}