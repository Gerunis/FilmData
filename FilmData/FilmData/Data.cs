using System;
using System.Collections.Generic;
using System.Text;

namespace FilmData
{
    public class Data
    {
        /// <summary>
        /// Список жанров
        /// </summary>
        public static List<string> FilmsGenres = new List<string>()
        {
            "Drama", "Romance", "Comedy", "Short",
            "Crime", "Mystery", "Thriller", "  Family",
            "Action", "Fantasy ", "Adventure", "Sci-Fi",
            "Animation", "History", "Horror", "Music",
            "War", "Documentary", "Biography", "Musical",
            "Sport", "Reality-TV", "Talk-Show", "Western",
            "News", "Game-Show", "Film-Noir", "Adult"
        };

        /// <summary>
        /// Список стран 
        /// </summary>
        public static List<string> FilmsCountries = new List<string>() { };

        public Dictionary<int, Film> Films { get; private set; }
        public Dictionary<int, Actor> Actors { get; private set; }

        private int filmId;
        private int actorId;
        private Stack<int> freeActorId;
        private Stack<int> freeFilmId;

        public Data()
        {
            Films = new Dictionary<int, Film>();
            Actors = new Dictionary<int, Actor>();
            filmId = 0;
            actorId = 0;
            freeActorId = new Stack<int>();
            freeFilmId = new Stack<int>();
        }

        public int GetActorId()
        {
            if (freeActorId.Count == 0)
                return freeActorId.Pop();
            return actorId++;
        }

        public int GetFilmId()
        {
            if (freeFilmId.Count == 0)
                return freeFilmId.Pop();
            return filmId++;
        }

        public void RemoveFilm(int id)
        {
            if (!Films.ContainsKey(id))
                throw new KeyNotFoundException("Id фильма не найдено");
            Films.Remove(id);
            freeFilmId.Push(id);
        }

        public void RemoveActor(int id)
        {
            if (!Actors.ContainsKey(id))
                throw new KeyNotFoundException("Id актера не найдено");
            Actors.Remove(id);
            freeActorId.Push(id);
        }
    }
}
