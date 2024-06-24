using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.BusinessLayer.Abstract;
using Travela.DtoLayer.Dtos.AboutDto;
using Travela.DtoLayer.Dtos.PackageDto;
using Travela.EntityLayer.Concrete;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackagesController : ControllerBase
    {
        private readonly IPackageService _packageService;
        private readonly IMapper _mapper;

        public PackagesController(IPackageService packageService, IMapper mapper)
        {
            _packageService = packageService;
            _mapper = mapper;
        }

        [HttpPost("PackageList")] // Change HttpGet to HttpPost
        public IActionResult PackageList()
        {
            var values = _packageService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreatePackage(PackageAddDto packageAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Package>(packageAddDto);
            _packageService.TInsert(values);
            return StatusCode(200, new { message = "Create successful" });
        }

        [HttpDelete("DeletePackage/{id}")]
        public IActionResult DeletePackage(int id)
        {
            _packageService.TDelete(id);
            return StatusCode(200);
        }

        [HttpGet("GetPackage")]
        public IActionResult GetPackage(int id)
        {
            var value = _packageService.TGetById(id);
            return Ok(value);
        }

        [HttpPost("Update")]
        public IActionResult UpdatePackage(PackageUpdateDto packageUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Package>(packageUpdateDto);
            _packageService.TUpdate(values);

            return StatusCode(200, new { message = "Update successful" });
        }


    }
}
