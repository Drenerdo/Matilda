using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matilda.Mirror.GUI.Amentities
{
    public class AmentitiesModel
    {
        public string Refid { set; get; }
        public string Name { set; get; }
        public string Brand { set; get; }
        public AmentitiesType Type { set; get; }
        public List<string> Photos { set; get; }
        public string MainPhoto { set; get; }
        public string Description { set; get; }
    }
}
