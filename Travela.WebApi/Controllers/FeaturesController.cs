using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.BusinessLayer.Abstract;
using Travela.DtoLayer.Dtos.AboutDto;
using Travela.DtoLayer.Dtos.FeatureDto;
using Travela.EntityLayer.Concrete;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeaturesController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }


        [HttpPost("FeatureList")] // Change HttpGet to HttpPost
        public IActionResult AboutList()
        {
            var values = _featureService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateFeature(FeatureAddDto featureAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Feature>(featureAddDto);
            _featureService.TInsert(values);
            return StatusCode(200, new { message = "Create successful" });
        }

        [HttpDelete("DeleteFeature/{id}")]
        public IActionResult DeleteFeature(int id)
        {
            _featureService.TDelete(id);
            return StatusCode(200);
        }

        [HttpGet("GetFeature")]
        public IActionResult GetFeature(int id)
        {
            var value = _featureService.TGetById(id);
            return Ok(value);
        }

        [HttpPost("Update")]
        public IActionResult UpdateFeature(FeatureUpdateDto featureUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Feature>(featureUpdateDto);
            _featureService.TUpdate(values);

            return StatusCode(200, new { message = "Update successful" });
        }

    }
}
