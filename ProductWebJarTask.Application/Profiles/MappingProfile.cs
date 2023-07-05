using AutoMapper;
using ProductWebJarTask.Application.DTOs.Product;
using ProductWebJarTask.Domain.Product;

namespace ProductWebJarTask.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        #region Product Mapping

        CreateMap<Product, ProductDto>().ReverseMap();
        CreateMap<Product, CreateProductDto>().ReverseMap();

        #endregion

    }
}