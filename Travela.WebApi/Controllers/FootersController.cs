using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.BusinessLayer.Abstract;
using Travela.DtoLayer.Dtos.FooterDto;
using Travela.EntityLayer.Concrete;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootersController : ControllerBase
    {
        private readonly IFooterService _footerService;
        private readonly IMapper _mapper;

        public FootersController(IFooterService footerService, IMapper mapper)
        {
            _footerService = footerService;
            _mapper = mapper;
        }

        [HttpPost("FooterList")] // Change HttpGet to HttpPost
        public IActionResult FooterList()
        {
            var values = _footerService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateFooter(FooterAddDto FooterAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Footer>(FooterAddDto);
            _footerService.TInsert(values);
            return StatusCode(200, new { message = "Create successful" });
        }


        [HttpDelete("DeleteFooter/{id}")]
        public IActionResult DeleteFooter(int id)
        {
            _footerService.TDelete(id);
            return StatusCode(200);
        }

        [HttpGet("GetFooter")]
        public IActionResult GetFooter(int id)
        {
            var value = _footerService.TGetById(id);
            return Ok(value);
        }

        [HttpPost("Update")]
        public IActionResult UpdateFooter(FooterUpdateDto FooterUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Footer>(FooterUpdateDto);
            _footerService.TUpdate(values);

            return StatusCode(200, new { message = "Update successful" });
        }


    }
}
