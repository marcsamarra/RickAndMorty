using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace RickAndMorty.Models
{
    public class Episode
    {
        public long id { get; set; }
        public long idEpisode { get; set; }
        public string name { get; set; }
        public string air_date { get; set; }
        public string episode { get; set; }
        public List<string> characters { get; set; }
        public string url { get; set; }
        public string created { get; set; }
    }
}