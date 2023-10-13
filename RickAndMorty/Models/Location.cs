using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Xml.Linq;

namespace RickAndMorty.Models
{
    public class Location
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string dimension { get; set; }
        public string[] residents { get; set; }
        public string url { get; set; }
        public string created { get; set; }
    }
}