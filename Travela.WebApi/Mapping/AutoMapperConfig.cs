using AutoMapper;
using Travela.DtoLayer.Dtos.AboutDto;
using Travela.DtoLayer.Dtos.CarouselDto;
using Travela.DtoLayer.Dtos.DestinationDto;
using Travela.DtoLayer.Dtos.FeatureDto;
using Travela.DtoLayer.Dtos.GuideDto;
using Travela.DtoLayer.Dtos.PackageDto;
using Travela.DtoLayer.Dtos.ServiceDto;
using Travela.DtoLayer.Dtos.TestimonialDto;
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

            CreateMap<PackageAddDto, Package>().ReverseMap();
            CreateMap<PackageUpdateDto, Package>().ReverseMap();

            CreateMap<GuideAddDto, Guide>().ReverseMap();
            CreateMap<GuideUpdateDto, Guide>().ReverseMap();

            CreateMap<TestimonialAddDto, Testimonial>().ReverseMap();
            CreateMap<TestimonialUpdateDto, Testimonial>().ReverseMap();

            CreateMap<CarouselAddDto, Carousel>().ReverseMap();
            CreateMap<CarouselUpdateDto, Carousel>().ReverseMap();

        }


    }
}
