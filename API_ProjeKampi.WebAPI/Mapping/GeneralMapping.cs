using API_ProjeKampi.WebAPI.Dtos.FeatureDtos;
using API_ProjeKampi.WebAPI.Dtos.MessageDtos;
using API_ProjeKampi.WebAPI.Dtos.ProductDtos;
using API_ProjeKampi.WebAPI.Entities;
using AutoMapper;

namespace API_ProjeKampi.WebAPI.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();

            CreateMap<Message, CreateMessageDto>().ReverseMap();
            CreateMap<Message, GetByIdMessageDto>().ReverseMap();
            CreateMap<Message, ResultMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();

            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductListWithCategoriesDto>().ForMember(x => x.CategoryName, 
                        y => y.MapFrom(z => z.Categories.Name)).ReverseMap();
        }
    }
}
