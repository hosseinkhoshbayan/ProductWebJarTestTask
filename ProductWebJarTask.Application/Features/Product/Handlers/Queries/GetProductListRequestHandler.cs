using AutoMapper;
using MediatR;
using ProductWebJarTask.Application.Contracts.Persistence;
using ProductWebJarTask.Application.DTOs.Product;
using ProductWebJarTask.Application.Features.Product.Requests.Queries;

namespace ProductWebJarTask.Application.Features.Product.Handlers.Queries;

public class GetProductListRequestHandler:
    IRequestHandler<GetProductListRequest,List<ProductDto>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetProductListRequestHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<List<ProductDto>> Handle(GetProductListRequest request, CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetAll();
       return _mapper.Map<List<ProductDto>>(products);
    }
}