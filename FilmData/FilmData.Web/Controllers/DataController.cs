using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmData.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilmData.Web.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ActorImage(int id)
        {
            byte[] foto;
            using (var db = new FilmDataDbContext())
            {
                foto = db.Actors.Find(id).Foto;
            }
            if (foto == null) return base.File(Properties.Resources.Nullimg, "image/jpeg");
            return base.File(foto, "image/jpeg");
        }

        public ActionResult FilmImage(int id)
        {
            byte[] poster;
            using (var db = new FilmDataDbContext())
            {
                poster = db.Films.Find(id).Poster;
            }
            if (poster == null) return base.File(Properties.Resources.Nullimg, "image/jpeg");
            return base.File(poster, "image/jpeg");
        }

        public IActionResult Films()
        {
            if(FilmDataDbContext.LocalFilms == null)
                FilmDataDbContext.UpdateLists();
            return View(FilmDataDbContext.LocalFilms);
        }

        public IActionResult Actors()
        {
            if (FilmDataDbContext.LocalActors == null)
                FilmDataDbContext.UpdateLists();
            return View(FilmDataDbContext.LocalActors);
        }

        public IActionResult Film(int id)
        {
            DbFilm film;
            using (var db = new FilmDataDbContext())
            {
                film = db.Films.Include(s => s.Credits).First(x => x.Id == id);
                List<DbActor> a = db.Actors.Include(x => x.Works).ToList();
            }
            return View(film);
        }

        public IActionResult Actor(int id)
        {
            DbActor actor;
            using (var db = new FilmDataDbContext())
            {
                actor = db.Actors.Include(s => s.Works).First(x => x.Id == id);
                List<DbFilm> a = db.Films.Include(x => x.Credits).ToList();
            }
            return View(actor);
        }
    }
}