using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FilmData.Web.Models;

namespace FilmData.Web.Controllers
{
    // >dotnet ef migration add testMigration in AspNet5MultipleProject
    public class UploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DoUpload(IFormFile file)
        {
            using (var stream = file.OpenReadStream())
            {
                var xs = new XmlSerializer(typeof(DataXml));
                var dataXml = (DataXml)xs.Deserialize(stream);
                var data = dataXml.ToData();
                var dbFilms = data.Films.ToDictionary(x => x.Key, x => new DbFilm(x.Value));
                var dbActors = data.Actors.ToDictionary(x => x.Key, x => new DbActor(x.Value));

                foreach (var film in data.Films)
                {
                    foreach (var work in film.Value.Credits)
                    {
                        var dbWork = new DbWork { Position = work.Position, Discription = work.Discription };
                        dbFilms[work.FilmId].Credits.Add(dbWork);
                        dbActors[work.ActorId].Works.Add(dbWork);
                    }
                }

                using (var db = new FilmDataDbContext())
                {
                    foreach (var film in dbFilms.Values)
                    {
                        db.Films.Add(film);
                    }

                    foreach (var actor in dbActors.Values)
                    {
                        db.Actors.Add(actor);
                    }
                    db.SaveChanges();
                }
                FilmDataDbContext.UpdateLists();
                return View(dataXml);
            }
        }
    }
}