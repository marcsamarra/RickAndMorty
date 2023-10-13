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
        public async Task<bool> Load()
        {
            var client = new HttpClient();

            Respuesta respuesta = await client.GetFromJsonAsync<Respuesta>("https://rickandmortyapi.com/api/episode");

            var a = respuesta;


            //db.Episodes.Add(a);
            //db.SaveChanges();

            //foreach(Episode episode in espisodes)
            //{


            //}
            return true;
        }

        public void Load1()
        {
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
                db.Episodes.Add(episode);
                db.SaveChanges();

            }


        }


    }
}