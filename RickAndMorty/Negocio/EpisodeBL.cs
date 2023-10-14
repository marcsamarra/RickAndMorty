using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Net.Http.Json;
using System.Net.Http;
using RickAndMorty.Models;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Text.Json;
using RickAndMorty.Data;
using RickAndMorty.Migrations;

namespace RickAndMorty.Negocio
{
    public class Respuesta
    {
        public Info info { get; set; }
        public Episode[] results { get; set; }
    }

    public class EpisodeBL
    {
        private RickAndMortyContext db = new RickAndMortyContext();

        static HttpWebRequest peticion;

        public void BorrarEpisodios()
        {
            db.EpisodeCharacters.RemoveRange(db.EpisodeCharacters);
            db.Episodes.RemoveRange(db.Episodes);
            db.SaveChanges();
        }

        public Character LoadCharacter(string CharacterURL)
        {
            Stream streamRespuesta;
            StreamReader reader;
            WebResponse respuesta;

            peticion = (HttpWebRequest)HttpWebRequest.Create(CharacterURL);

            respuesta = peticion.GetResponse();

            streamRespuesta = respuesta.GetResponseStream();
            reader = new StreamReader(streamRespuesta);
            string text = reader.ReadToEnd();

            var respuesta1 = JsonSerializer.Deserialize<Character>(text);
            return respuesta1;
        }

        public void Load1()
        {
            BorrarEpisodios();

            Stream streamRespuesta;
            StreamReader reader;
            WebResponse respuesta;

            peticion = (HttpWebRequest)HttpWebRequest.Create("https://rickandmortyapi.com/api/episode");

            respuesta = peticion.GetResponse();

            streamRespuesta = respuesta.GetResponseStream();
            reader = new StreamReader(streamRespuesta);
            string text = reader.ReadToEnd();

            var respuesta1 = JsonSerializer.Deserialize<Respuesta>(text);

            foreach (Episode episode in respuesta1.results)
            {
                episode.idEpisode = episode.id;
                db.Episodes.Add(episode);

                foreach (string urlepisodeCharacter in episode.characters)
                {
                    EpisodeCharacter episodeCharacter = new EpisodeCharacter();
                    episodeCharacter.Idepisode = episode.id;
                    episodeCharacter.Character = urlepisodeCharacter;
                    db.EpisodeCharacters.Add(episodeCharacter);
                }

                db.SaveChanges();
            }

        }

        internal List<Character> LoadCharacters(long id)
        {

            List<Character> listCharacter = new List<Character>();

            var episodeCharacters = db.EpisodeCharacters.Where(o => o.Idepisode == id);

            foreach (EpisodeCharacter episodeCharacter in episodeCharacters)
            {
                listCharacter.Add(LoadCharacter(episodeCharacter.Character));
            }

            return listCharacter;

        }
    }
}