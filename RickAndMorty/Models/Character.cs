using RickAndMorty.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Xml.Linq;

namespace RickAndMorty.Models
{
    public class Character
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string type { get; set; }
        public string gender { get; set; }
        public Location origin { get; set; }
        public Location location { get; set; }
        public string image { get; set; } 
        public string[] episode { get; set; }
        public string url { get; set; }
        public string created { get; set; }

    }
}