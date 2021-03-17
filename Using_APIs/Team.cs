using System;
using System.Collections.Generic;
using System.Text;

namespace Using_APIs
{
    public class NameTranslations
    {
        public string en { get; set; }
        public string ru { get; set; }
        public string de { get; set; }
        public string es { get; set; }
        public string fr { get; set; }
        public string zh { get; set; }
        public string tr { get; set; }
        public string el { get; set; }
        public string it { get; set; }
        public string nl { get; set; }
        public string pt { get; set; }
    }

    public class Details
    {
        public string country { get; set; }
        public string country_i_s_o { get; set; }
        public string date_of_birth { get; set; }
        public string birthplace { get; set; }
        public string plays { get; set; }
        public string residence { get; set; }
        public string weight { get; set; }
        public double height_meters { get; set; }
        public string prize_current { get; set; }
        public string prize_total { get; set; }
        public int prize_current_euros { get; set; }
        public int prize_total_euros { get; set; }
        public string flag { get; set; }
    }

    public class Sport
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
    }    

    public class Datum
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public NameTranslations name_translations { get; set; }
        public string name_short { get; set; }
        public string name_full { get; set; }
        public string name_code { get; set; }
        public bool has_sub { get; set; }
        public bool has_logo { get; set; }
        public string logo { get; set; }
        public string gender { get; set; }
        public bool is_nationality { get; set; }
        public string country_code { get; set; }
        public string country { get; set; }
        public string flag { get; set; }
        public string foundation { get; set; }
        public Details details { get; set; }
        public Sport sport { get; set; }
    }

    public class Team
    {
        public IList<Datum> data { get; set; }
    }
}
