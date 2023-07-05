using MediatR;
using ProductWebJarTask.Application.DTOs.Product;

namespace ProductWebJarTask.Application.Features.Product.Requests.Queries;

public class GetProductDetailRequest:IRequest<ProductDto>
{
    public long Id { get; set; }
}