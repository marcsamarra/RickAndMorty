using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RickAndMorty.Data;
using RickAndMorty.Models;

namespace RickAndMorty.Controllers
{
    public class EpisodeCharactersController : Controller
    {
        private RickAndMortyContext db = new RickAndMortyContext();

        // GET: EpisodeCharacters
        public ActionResult Index()
        {
            return View(db.EpisodeCharacters.ToList());
        }

        // GET: EpisodeCharacters/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EpisodeCharacter episodeCharacter = db.EpisodeCharacters.Find(id);
            if (episodeCharacter == null)
            {
                return HttpNotFound();
            }
            return View(episodeCharacter);
        }

        // GET: EpisodeCharacters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EpisodeCharacters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Idepisode,Character")] EpisodeCharacter episodeCharacter)
        {
            if (ModelState.IsValid)
            {
                db.EpisodeCharacters.Add(episodeCharacter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(episodeCharacter);
        }

        // GET: EpisodeCharacters/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EpisodeCharacter episodeCharacter = db.EpisodeCharacters.Find(id);
            if (episodeCharacter == null)
            {
                return HttpNotFound();
            }
            return View(episodeCharacter);
        }

        // POST: EpisodeCharacters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Idepisode,Character")] EpisodeCharacter episodeCharacter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(episodeCharacter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(episodeCharacter);
        }

        // GET: EpisodeCharacters/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EpisodeCharacter episodeCharacter = db.EpisodeCharacters.Find(id);
            if (episodeCharacter == null)
            {
                return HttpNotFound();
            }
            return View(episodeCharacter);
        }

        // POST: EpisodeCharacters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            EpisodeCharacter episodeCharacter = db.EpisodeCharacters.Find(id);
            db.EpisodeCharacters.Remove(episodeCharacter);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
