using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travela.DtoLayer.Dtos.CarouselDto
{
    public class CarouselUpdateDto
    {
        public int CarouselId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
