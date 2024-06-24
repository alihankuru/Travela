using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.BusinessLayer.Abstract;
using Travela.DtoLayer.Dtos.AboutDto;
using Travela.DtoLayer.Dtos.GuideDto;
using Travela.EntityLayer.Concrete;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuidesController : ControllerBase
    {
        private readonly IGuideService _guideService;
        private readonly IMapper _mapper;

        public GuidesController(IGuideService guideService, IMapper mapper)
        {
            _guideService = guideService;
            _mapper = mapper;
        }

        [HttpPost("GuideList")] // Change HttpGet to HttpPost
        public IActionResult GuideList()
        {
            var values = _guideService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateGuide(GuideAddDto guideAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Guide>(guideAddDto);
            _guideService.TInsert(values);
            return StatusCode(200, new { message = "Create successful" });
        }

        [HttpDelete("DeleteGuide/{id}")]
        public IActionResult DeleteGuide(int id)
        {
            _guideService.TDelete(id);
            return StatusCode(200);
        }

        [HttpGet("GetGuide")]
        public IActionResult GetGuide(int id)
        {
            var value = _guideService.TGetById(id);
            return Ok(value);
        }

        [HttpPost("Update")]
        public IActionResult UpdateGuide(GuideUpdateDto guideUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Guide>(guideUpdateDto);
            _guideService.TUpdate(values);

            return StatusCode(200, new { message = "Update successful" });
        }

    }
}
