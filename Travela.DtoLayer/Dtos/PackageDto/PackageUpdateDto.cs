using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travela.DtoLayer.Dtos.PackageDto
{
    public class PackageUpdateDto
    {
        public int PackageId { get; set; }
        public string CountryName { get; set; }
        public string ImageUrl { get; set; }
        public int Day { get; set; }
        public int PersonCount { get; set; }
        public string Title { get; set; }
        public int Review { get; set; }
        public int CommentCount { get; set; }
        public decimal Price { get; set; }
    }
}
