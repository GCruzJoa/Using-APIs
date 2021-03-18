using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Using_APIs.Models
{
    public class Datum
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_short")]
        public string NameShort { get; set; }

        [JsonProperty("name_full")]
        public string NameFull { get; set; }

        [JsonProperty("name_code")]
        public string NameCode { get; set; }

        [JsonProperty("has_sub")]
        public bool HasSub { get; set; }

        [JsonProperty("has_logo")]
        public bool HasLogo { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("is_nationality")]
        public bool IsNationality { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("foundation")]
        public string Foundation { get; set; }

        [JsonProperty("sport")]
        public Sport Sport { get; set; }
    }
}
