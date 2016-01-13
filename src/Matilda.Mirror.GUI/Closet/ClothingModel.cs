using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matilda.Mirror.GUI.Closet
{
    public class ClothingModel
    {
        public string Refid { set; get; }
        public string Name { set; get; }
        public string Brand { set; get; }
        public ClothingType Type { set; get; }
        public List<String> Photos { get; set; }
        public string MainPhoto { set; get; }
        public double Price { set; get; }
        public PriceUnit Unit { set; get; }
        public string Description { set; get; }
        public List<Size> Sizes { set; get; }
        public List<Color> Colors { set; get; }
    }
}
