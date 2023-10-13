using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RickAndMorty.Models
{
    public class Info
    {
        public long count {get; set;}
        public long pages { get; set;}   
        public string next { get; set;}
        public string prev { get; set;}
    }
}