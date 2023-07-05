using FluentValidation;
using ProductWebJarTask.Application.Contracts.Persistence;

namespace ProductWebJarTask.Application.DTOs.Product.Validators;

public class IProductDtoValidator : AbstractValidator<IProductDto>
{
    private readonly IProductRepository _productRepository;

    public IProductDtoValidator(IProductRepository productRepository)
    {
        _productRepository = productRepository;

        RuleFor(p => p.AccessoryPrice)
            .GreaterThan(0).WithMessage("{PropertyName} باید بیشتر از {ComparisonValue}");

        RuleFor(p => p.DiscountExpireAt)
            .GreaterThanOrEqualTo(DateTime.Now)
            .WithMessage("{PropertyName} باید بیشتر از {ComparisonValue}");
    }
}