using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductWebJarTask.Application.DTOs.Product;
using ProductWebJarTask.Application.Features.Product.Requests.Commands;
using ProductWebJarTask.Application.Features.Product.Requests.Queries;

namespace ProductWebJarTask.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    //Get: api/<ProductController>
    [HttpGet]
    public async Task<ActionResult<List<ProductDto>>> Get()
    {
        var products = await _mediator.Send(new GetProductListRequest());
        return Ok(products);
    }

    //Get: api/<ProductController>/1
    [HttpGet("{id}")]
    public async Task<ActionResult<ProductDto>> Get(long id)
    {
        var product = await _mediator.Send(new GetProductDetailRequest { Id = id });
        return Ok(product);
    }

    // POST api/<ProductController>
    [HttpPost]
    public async Task<ActionResult> Post([FromBody] CreateProductDto createProduct)
    {
        var command = new CreateProductCommand { CreateProductDto = createProduct };
        var response = await _mediator.Send(command);
        return Ok(response);
    }
}