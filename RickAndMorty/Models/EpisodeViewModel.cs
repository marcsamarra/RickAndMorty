using RickAndMorty.Models;
using RickAndMorty.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.WebPages;

namespace RickAndMorty.Models
{
    public class EpisodeViewModel
    {
        private Episode episode1;

        public EpisodeViewModel(Episode episode1)
        {
            this.id = episode1.id;
            this.name = episode1.name;
            this.air_date = episode1.air_date;
            this.episode = episode1.episode;
            this.url = episode1.url;    
            this.created = episode1.created;

            this.characters = new EpisodeBL().LoadCharacters(episode1.idEpisode);
        }

        public long id { get; set; }
        public string name { get; set; }
        public string air_date { get; set; }
        public string episode { get; set; }
        public List<Character> characters { get; set; }
        public string url { get; set; }
        public string created { get; set; }
    }
}