using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RickAndMorty.Models
{
    public class EpisodeCharacter
    {
        public long Id { get; set; }
        public long Idepisode { get; set; }
        public string Character { get; set; }   
    }
}