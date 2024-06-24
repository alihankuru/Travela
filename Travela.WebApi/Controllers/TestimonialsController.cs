using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.BusinessLayer.Abstract;
using Travela.DtoLayer.Dtos.AboutDto;
using Travela.DtoLayer.Dtos.TestimonialDto;
using Travela.EntityLayer.Concrete;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialsController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpPost("TestimonialList")] // Change HttpGet to HttpPost
        public IActionResult TestimonialList()
        {
            var values = _testimonialService.TGetListAll();
            return Ok(values);
        }


        [HttpPost]
        public IActionResult CreateTestimonial(TestimonialAddDto testimonialAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Testimonial>(testimonialAddDto);
            _testimonialService.TInsert(values);
            return StatusCode(200, new { message = "Create successful" });
        }

        [HttpDelete("DeleteTestimonial/{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            _testimonialService.TDelete(id);
            return StatusCode(200);
        }

        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }

        [HttpPost("Update")]
        public IActionResult UpdateTestimonial(TestimonialUpdateDto testimonialUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Testimonial>(testimonialUpdateDto);
            _testimonialService.TUpdate(values);

            return StatusCode(200, new { message = "Update successful" });
        }

    }
}
