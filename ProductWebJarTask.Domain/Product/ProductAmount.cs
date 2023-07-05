using ProductWebJarTask.Domain.Common;

namespace ProductWebJarTask.Domain.Product;

public class ProductAmount:BaseDomainEntity
{
    #region properties

    public long ProductId { get; set; }

    public long DiscountAmount { get; set; }

    public DateTime? DiscountExpireAt { get; set; }

    #endregion

    #region relationes

    public ICollection<Product> Products { get; set; }

    public ICollection<ProductAccessory> ProductAccessories { get; set; }

    #endregion
}