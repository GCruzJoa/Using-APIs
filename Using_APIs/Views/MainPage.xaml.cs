using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace Using_APIs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public class DemoApi
        {
            public int userId { get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public string body { get; set; }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://sportscore1.p.rapidapi.com/teams"),
                Headers =
                {
                    { "x-rapidapi-key", "4ea8d7e6f9mshd31033cdadc032bp1b5777jsn07633bf1455a" },
                    { "x-rapidapi-host", "sportscore1.p.rapidapi.com" },
                },
            };

            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                //var result = JsonConvert.DeserializeObject<List<DemoApi>>(content);
                var result = JsonConvert.DeserializeObject<Team>(content).data.ToList();

                //var result = JsonConvert.DeserializeObject<Sport>(content).ToString();

                ListDemo.ItemsSource = result;
            }

        }


    }
}
