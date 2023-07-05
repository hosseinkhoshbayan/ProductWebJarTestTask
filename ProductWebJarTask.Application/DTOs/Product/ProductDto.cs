using ProductWebJarTask.Application.DTOs.Common;
using ProductWebJarTask.Domain.Product;

namespace ProductWebJarTask.Application.DTOs.Product;

public class ProductDto:BaseDto
{
    public string ProductName { get; set; }

    public string ProductImage { get; set; }

    public string ProductFeatureName { get; set; }

    public string NumberOfProduct { get; set; }

    public string ProductColor { get; set; }

    public long ProductPrice { get; set; }

    public string AccessoryName { get; set; }

    public long AccessoryPrice { get; set; }

    public long DiscountAmount { get; set; }

    public DateTime? DiscountExpireAt { get; set; }

    public ProductFeature ProductFeature { get; set; }

    public long ProductFeatureId { get; set; }

    public ProductAccessory ProductAccessory { get; set; }

    public long ProductAccessoryId { get; set; }

    public ProductAmount ProductAmount { get; set; }

    public long ProductAmountId { get; set; }

}