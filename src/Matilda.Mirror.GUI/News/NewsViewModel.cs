using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Matilda.Mirror.GUI.News;

namespace Matilda.Mirror.GUI.News
{
   public class NewsViewModel: PropertyChangedBase
    {
        private ObservableCollection<NewsModel.ResultForList> newsList;
        public ObservableCollection<NewsModel.ResultForList> NewsList
        {
            get
            {
                return newsList;
            }
            set
            {
                if (newsList != value)
                {
                    newsList = value;
                    NotifyPropertyChanged();
                }
            }
        }
      

        public NewsViewModel()
        {
            NewsList = new ObservableCollection<NewsModel.ResultForList>();
            GetAllNews();
        }
        public async void GetAllNews()
        {
            try
            {
                string provideUri = "http://api.nytimes.com/svc/topstories/v1/home.json?api-key=c2e757d3535346b87e7ed65fd731d384:7:74319570";

                HttpClient client = new HttpClient();
                string jsonstring = await client.GetStringAsync(provideUri);
                var response = JsonConvert.DeserializeObject<NewsModel.RootObject>(jsonstring);
                if (response.status == "OK")
                {
                    if(response.results!=null)
                    {
                        if(response.results.Count!=0)
                        {
                            NewsList.Clear();
                            foreach (var item in response.results.Take(6))
                            {
                                string imageUrl = "ms-appx:///Assets/image_preview.jpg";
                                if (!string.IsNullOrEmpty(item.multimedia.ToString()))
                                {
                                    string data = item.multimedia.ToString().Replace("\r\n","");
                                    data = "{result :" + data + "}";
                                    var MultimediaResponse = JsonConvert.DeserializeObject<NewsModel.Multimedia>(data);
                                    imageUrl = MultimediaResponse.result.LastOrDefault().url;
                                }
                                NewsList.Add(new NewsModel.ResultForList()
                                {
                                    title = item.title,
                                    imageurl = imageUrl
                                });
                            }
                        }
                    }
                  
                }
            }
            catch(Exception ex)
            {

            }
            

        }
    }
}
