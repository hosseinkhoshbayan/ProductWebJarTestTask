using ProductWebJarTask.Application.DTOs.Common;

namespace ProductWebJarTask.Application.DTOs.Product;

public class CreateProductDto:BaseDto,IProductDto
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
}