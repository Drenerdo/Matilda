using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matilda.Mirror.GUI.News
{
   public class NewsModel
    {

        public class Result
        {
            public string section { get; set; }
            public string subsection { get; set; }
            public string title { get; set; }
            public string @abstract { get; set; }
            public string url { get; set; }
            public string byline { get; set; }
            public string item_type { get; set; }
            public string updated_date { get; set; }
            public string created_date { get; set; }
            public string published_date { get; set; }
            public string material_type_facet { get; set; }
            public string kicker { get; set; }
            public object des_facet { get; set; }
            public object org_facet { get; set; }
            public object per_facet { get; set; }
            public object geo_facet { get; set; }
            public object multimedia { get; set; }
        }
        public class ResultForList
        {
            public string section { get; set; }
            public string subsection { get; set; }
            public string title { get; set; }
            public string imageurl { get; set; }
            public string url { get; set; }
            public string byline { get; set; }
            public string item_type { get; set; }
            public string updated_date { get; set; }
            public string created_date { get; set; }
            public string published_date { get; set; }
            public string material_type_facet { get; set; }
            public string kicker { get; set; }
            public object des_facet { get; set; }
            public object org_facet { get; set; }
            public object per_facet { get; set; }
            public object geo_facet { get; set; }
            public object multimedia { get; set; }
        }
        public class RootObject
        {
            public string status { get; set; }
            public string copyright { get; set; }
            public string section { get; set; }
            public string last_updated { get; set; }
            public int num_results { get; set; }
            public List<Result> results { get; set; }
        }
        public class MultimediaResult
        {
            public string url { get; set; }
            public string format { get; set; }
            public int height { get; set; }
            public int width { get; set; }
            public string type { get; set; }
            public string subtype { get; set; }
            public string caption { get; set; }
            public string copyright { get; set; }

        }
        public class Multimedia
        {
            public List<MultimediaResult> result { get; set; }
        }
    }
  
}
