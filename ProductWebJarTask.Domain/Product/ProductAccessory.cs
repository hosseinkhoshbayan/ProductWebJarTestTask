using ProductWebJarTask.Domain.Common;

namespace ProductWebJarTask.Domain.Product;

public class ProductAccessory:BaseDomainEntity
{
    #region properties

    public long ProductId { get; set; }

    public long ProductFeatureId { get; set; }

    public long ProductAmountId { get; set; }

    public string AccessoryName { get; set; }

    public long AccessoryPrice { get; set; }

    #endregion

    #region relationes

    public ICollection<Product> Products { get; set; }

    public ProductFeature ProductFeature { get; set; }

    public ProductAmount ProductAmount { get; set; }

    #endregion
}