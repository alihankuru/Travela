using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.BusinessLayer.Abstract;
using Travela.DtoLayer.Dtos.CarouselDto;
using Travela.EntityLayer.Concrete;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarouselsController : ControllerBase
    {
        private readonly ICarouselService _carouselService;
        private readonly IMapper _mapper;

        public CarouselsController(ICarouselService carouselService, IMapper mapper)
        {
            _carouselService = carouselService;
            _mapper = mapper;
        }

        [HttpPost("CarouselList")] // Change HttpGet to HttpPost
        public IActionResult CarouselList()
        {
            var values = _carouselService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateCarousel(CarouselAddDto CarouselAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Carousel>(CarouselAddDto);
            _carouselService.TInsert(values);
            return StatusCode(200, new { message = "Create successful" });
        }


        [HttpDelete("DeleteCarousel/{id}")]
        public IActionResult DeleteCarousel(int id)
        {
            _carouselService.TDelete(id);
            return StatusCode(200);
        }

        [HttpGet("GetCarousel")]
        public IActionResult GetCarousel(int id)
        {
            var value = _carouselService.TGetById(id);
            return Ok(value);
        }

        [HttpPost("Update")]
        public IActionResult UpdateCarousel(CarouselUpdateDto CarouselUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Carousel>(CarouselUpdateDto);
            _carouselService.TUpdate(values);

            return StatusCode(200, new { message = "Update successful" });
        }

    }
}
