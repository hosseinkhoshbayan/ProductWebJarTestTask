using AutoMapper;
using MediatR;
using ProductWebJarTask.Application.Contracts.Persistence;
using ProductWebJarTask.Application.DTOs.Product.Validators;
using ProductWebJarTask.Application.Features.Product.Requests.Commands;
using ProductWebJarTask.Application.Responses;

namespace ProductWebJarTask.Application.Features.Product.Handlers.Commands;

public class CreateProductCommandHandler:
    IRequestHandler<CreateProductCommand,long>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<long> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var response = new BaseCommandResponse();
        var validator = new CreateProductDtoValidator(_productRepository);
        var validatorResult = await validator.ValidateAsync(request.CreateProductDto);

        if (validatorResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "افزودن محصول جدید با خطا مواجه شد";
            response.Errors = validatorResult.Errors.Select(q =>q.ErrorMessage).ToList();
        }

        var product = _mapper.Map<Domain.Product.Product>(request.CreateProductDto);
        product = await _productRepository.Add(product);

        response.Success = true;
        response.Message = "محصول جدید با موفقیت اضافه گردید";
        response.Id = product.Id;

        return response.Id;

    }
}