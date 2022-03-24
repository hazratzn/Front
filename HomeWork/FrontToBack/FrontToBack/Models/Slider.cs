using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Models
{
    public class Slider:BaseEntity
    {
        public string Image { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ClassName { get; set; }


    }
}
