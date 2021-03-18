using Newtonsoft.Json;
using System.Collections.ObjectModel;
using Using_APIs.Models;

namespace Using_APIs
{
    public class Team
    {
        [JsonProperty("data")]
        public ObservableCollection<Datum> Data { get; set; }
    }
}
