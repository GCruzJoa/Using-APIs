using System;
using System.Collections.Generic;
using System.Text;

namespace Using_APIs.Models
{
    public class Datum
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Name_short { get; set; }
        public string Name_full { get; set; }
        public string Name_code { get; set; }
        public string Logo { get; set; }
        public bool Is_nationality { get; set; }
        public string Country_code { get; set; }
        public string Country { get; set; }
        public string Flag { get; set; }
        public string Foundation { get; set; }
        public Sport Sport { get; set; }
    }
}
