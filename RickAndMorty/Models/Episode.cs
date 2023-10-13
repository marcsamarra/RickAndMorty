using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RickAndMorty.Models
{
    public class Episode
    {
        public long id { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }
        public string air_date { get; set; }
        public string espisode { get; set; }
        public string[] characters { get; set; }
        public string url { get; set; }
        public string created { get; set; }
    }
}