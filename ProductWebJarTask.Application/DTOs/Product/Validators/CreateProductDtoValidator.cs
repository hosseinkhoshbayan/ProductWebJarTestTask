using FluentValidation;
using ProductWebJarTask.Application.Contracts.Persistence;

namespace ProductWebJarTask.Application.DTOs.Product.Validators;

public class CreateProductDtoValidator: AbstractValidator<CreateProductDto>
{
    private readonly IProductRepository _productRepository;

    public CreateProductDtoValidator(IProductRepository productRepository)
    {
        _productRepository = productRepository;
        Include(new IProductDtoValidator(_productRepository));
    }
}