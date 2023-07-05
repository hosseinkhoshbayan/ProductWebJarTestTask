using ProductWebJarTask.Domain.Common;

namespace ProductWebJarTask.Domain.Product;

public class ProductFeature:BaseDomainEntity
{
    #region properties

    public long ProductId { get; set; }

    public long ProductAccessoryId { get; set; }

    public string ProductFeatureName { get; set; }

    public string NumberOfProduct { get; set; }

    public string ProductColor { get; set; }

    public long ProductPrice { get; set; }

    #endregion

    #region relationes

    public ICollection<Product> Products { get; set; }

    public ICollection<ProductAccessory> ProductAccessory { get; set; }

    #endregion
}