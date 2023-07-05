using Microsoft.EntityFrameworkCore;
using ProductWebJarTask.Application.Contracts.Persistence;
using ProductWebJarTask.Domain.Product;
using ProductWebJarTask.Persistence.Context;

namespace ProductWebJarTask.Persistence.Repositories;

public class ProductRepository :GenericRepository<Product>,IProductRepository
{
    private readonly EShopWebjarTestTaskDbContext _dbContext;
    public ProductRepository(EShopWebjarTestTaskDbContext context, EShopWebjarTestTaskDbContext dbContext) : base(context)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Product>> GetProductsList()
    {
        var products = await _dbContext.Products.Include(t => t.ProductFeature)
            .ThenInclude(t => t.ProductAccessory)
            .Include(t => t.ProductAmount)
            .ToListAsync();
           ;
       return products;
    }

    public async Task<Product> GetProductWithDetails(long Id)
    {
        var product = await _dbContext.Products.Include(t => t.ProductFeature)
            .ThenInclude(t => t.ProductAccessory)
            .Include(t => t.ProductAmount)
            .FirstOrDefaultAsync(i=>i.Id == Id);

        return product;
    }
}