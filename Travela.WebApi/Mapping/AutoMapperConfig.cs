using AutoMapper;
using Travela.DtoLayer.Dtos.AboutDto;
using Travela.DtoLayer.Dtos.DestinationDto;
using Travela.DtoLayer.Dtos.FeatureDto;
using Travela.DtoLayer.Dtos.ServiceDto;
using Travela.EntityLayer.Concrete;

namespace Travela.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AboutAddDto, About>().ReverseMap();
            CreateMap<AboutUpdateDto, About>().ReverseMap();

            CreateMap<FeatureAddDto, Feature>().ReverseMap();
            CreateMap<FeatureUpdateDto, Feature>().ReverseMap();

            CreateMap<DestinationAddDto, Destination>().ReverseMap();
            CreateMap<DestinationUpdateDto, Destination>().ReverseMap();

            CreateMap<ServiceAddDto, Service>().ReverseMap();
            CreateMap<ServiceUpdateDto, Service>().ReverseMap();

        }


    }
}
