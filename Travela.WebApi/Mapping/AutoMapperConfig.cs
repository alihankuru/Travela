using AutoMapper;
using Travela.DtoLayer.Dtos.AboutDto;
using Travela.EntityLayer.Concrete;

namespace Travela.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AboutAddDto, About>().ReverseMap();
            CreateMap<AboutUpdateDto, About>().ReverseMap();

        }
       

    }
}
