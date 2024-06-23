using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.BusinessLayer.Abstract;
using Travela.DtoLayer.Dtos.AboutDto;
using Travela.DtoLayer.Dtos.DestinationDto;
using Travela.EntityLayer.Concrete;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationController : ControllerBase
    {
        private readonly IDestinationService _destinationService;
        private readonly IMapper _mapper;

        public DestinationController(IDestinationService destinationService, IMapper mapper)
        {
            _destinationService = destinationService;
            _mapper = mapper;
        }

        [HttpPost("DestinationList")] // Change HttpGet to HttpPost
        public IActionResult AboutList()
        {
            var values = _destinationService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateDestination(DestinationAddDto destinationAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Destination>(destinationAddDto);
            _destinationService.TInsert(values);
            return StatusCode(200, new { message = "Create successful" });
        }

        [HttpDelete("DeleteDestination/{id}")]
        public IActionResult DeleteAbout(int id)
        {
            _destinationService.TDelete(id);
            return StatusCode(200);
        }

        [HttpGet("GetDestination")]
        public IActionResult GetDestination(int id)
        {
            var value = _destinationService.TGetById(id);
            return Ok(value);
        }

        [HttpPost("Update")]
        public IActionResult UpdateDestination(DestinationUpdateDto destinationUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Destination>(destinationUpdateDto);
            _destinationService.TUpdate(values);

            return StatusCode(200, new { message = "Update successful" });
        }

    }
}
