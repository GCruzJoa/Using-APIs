using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Using_APIs.Models
{
    public class Sport
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

}
