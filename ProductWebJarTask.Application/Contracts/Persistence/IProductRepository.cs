using ProductWebJarTask.Domain.Product;

namespace ProductWebJarTask.Application.Contracts.Persistence;

public interface IProductRepository:IGenericRepository<Product>
{
    Task<List<Product>> GetProductsList();

    Task<Product> GetProductWithDetails(long Id);
}