using AutoMapper;
using MediatR;
using ProductWebJarTask.Application.Contracts.Persistence;
using ProductWebJarTask.Application.DTOs.Product;
using ProductWebJarTask.Application.Features.Product.Requests.Queries;

namespace ProductWebJarTask.Application.Features.Product.Handlers.Queries;

public class GetProductDetailRequestHandler:IRequestHandler<
GetProductDetailRequest,ProductDto
>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetProductDetailRequestHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ProductDto> Handle(GetProductDetailRequest request, CancellationToken cancellationToken)
    {
        var product = await _productRepository
            .GetProductWithDetails(request.Id);

        return _mapper.Map<ProductDto>(product);
    }
}