using MediatR;
using ProductWebJarTask.Application.DTOs.Product;

namespace ProductWebJarTask.Application.Features.Product.Requests.Queries;

public class GetProductListRequest:IRequest<List<ProductDto>>
{
    
}