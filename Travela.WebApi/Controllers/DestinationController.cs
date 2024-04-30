using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.BusinessLayer.Abstract;
using Travela.EntityLayer.Concrete;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationController : ControllerBase
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }


        [HttpGet]
        public IActionResult DestinationList()
        {
            var values = _destinationService.TGetListAll();
            return Ok(values);  
        }

        [HttpPost]
        public IActionResult CreateDestination(Destination Destination)
        {
            _destinationService.TInsert(Destination);
            return Ok("Kategori ekleme işlemi başarıyla tamamlandı.");
        }

        [HttpDelete]
        public IActionResult DeleteDestination(int id)
        {
            _destinationService.TDelete(id);
            return Ok("Kategori silme işlemi başarıyla tamamlandı");
        }

        [HttpGet("GetDestination")]
        public IActionResult GetDestination(int id)
        {
            var value = _destinationService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateDestination(Destination Destination)
        {
            _destinationService.TUpdate(Destination);
            return Ok("Kategori güncelleme işlemi başarıyla tammalandı.");
        }
    }
}
