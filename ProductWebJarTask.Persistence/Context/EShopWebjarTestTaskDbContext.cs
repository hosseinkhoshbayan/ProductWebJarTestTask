using Microsoft.EntityFrameworkCore;
using ProductWebJarTask.Domain.Common;
using ProductWebJarTask.Domain.Product;

namespace ProductWebJarTask.Persistence.Context;

public class EShopWebjarTestTaskDbContext:DbContext
{
    public EShopWebjarTestTaskDbContext(DbContextOptions<EShopWebjarTestTaskDbContext> options) : base(options)
    {

    }

    #region Products

    public DbSet<Product> Products { get; set; }

    public DbSet<ProductFeature> ProductFeatures { get; set; }
    public DbSet<ProductAccessory> ProductAccessories { get; set; }
    public DbSet<ProductAmount> ProductAmounts { get; set; }

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(typeof(EShopWebjarTestTaskDbContext).Assembly);
    }

    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
        {
            entry.Entity.LastModifiedDate = DateTime.Now;

            if (entry.State == EntityState.Added)
            {
                entry.Entity.DateCreated = DateTime.Now;
            }
        }
        return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }

    public override int SaveChanges()
    {
        foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
        {
            entry.Entity.LastModifiedDate = DateTime.Now;

            if (entry.State == EntityState.Added)
            {
                entry.Entity.DateCreated = DateTime.Now;
            }
        }
        return base.SaveChanges();
    }
}