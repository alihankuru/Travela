using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travela.DtoLayer.Dtos.GuideDto
{
    public class GuideUpdateDto
    {
        public int GuideId { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
}
