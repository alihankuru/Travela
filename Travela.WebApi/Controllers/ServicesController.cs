using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.BusinessLayer.Abstract;
using Travela.DtoLayer.Dtos.AboutDto;
using Travela.DtoLayer.Dtos.ServiceDto;
using Travela.EntityLayer.Concrete;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceService _serviceService;
        private readonly IMapper _mapper;

        public ServicesController(IServiceService serviceService, IMapper mapper)
        {
            _serviceService = serviceService;
            _mapper = mapper;
        }

        [HttpPost("ServiceList")] // Change HttpGet to HttpPost
        public IActionResult AboutList()
        {
            var values = _serviceService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateService(ServiceAddDto serviceAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Service>(serviceAddDto);
            _serviceService.TInsert(values);
            return StatusCode(200, new { message = "Create successful" });
        }

        [HttpDelete("DeleteService/{id}")]
        public IActionResult DeleteService(int id)
        {
            _serviceService.TDelete(id);
            return StatusCode(200);
        }


        [HttpGet("GetService")]
        public IActionResult GetService(int id)
        {
            var value = _serviceService.TGetById(id);
            return Ok(value);
        }

        [HttpPost("Update")]
        public IActionResult UpdateService(ServiceUpdateDto serviceUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Service>(serviceUpdateDto);
            _serviceService.TUpdate(values);

            return StatusCode(200, new { message = "Update successful" });
        }


    }
}
