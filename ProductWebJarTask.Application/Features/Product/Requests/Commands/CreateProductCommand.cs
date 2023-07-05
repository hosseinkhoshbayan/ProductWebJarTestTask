using MediatR;
using ProductWebJarTask.Application.DTOs.Product;

namespace ProductWebJarTask.Application.Features.Product.Requests.Commands;

public class CreateProductCommand:IRequest<long>
{
    public CreateProductDto CreateProductDto { get; set; }
}