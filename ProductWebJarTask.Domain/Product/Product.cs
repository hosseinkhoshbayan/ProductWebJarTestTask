using ProductWebJarTask.Domain.Common;

namespace ProductWebJarTask.Domain.Product;

public class Product :BaseDomainEntity
{
    #region properties

    public string ProductName { get; set; }

    public string ProductImage { get; set; }

    #endregion

    #region relationes

    public ProductFeature ProductFeature { get; set; }

    public ProductAccessory ProductAccessory { get; set; }

    public ProductAmount ProductAmount { get; set; }

    #endregion
}