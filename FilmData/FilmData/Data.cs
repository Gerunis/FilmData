using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace FilmData
{
    [Serializable]
    public class Data
    {
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

        public Data(List<Film> films, List<Actor> actors,
            int filmId, int actorId, Stack<int> freeActorId, Stack<int> freeFilmId)
        {
            Films = films.ToDictionary(x => x.Id, x => x);
            Actors = actors.ToDictionary(x => x.Id, x => x);
            this.filmId = filmId;
            this.actorId = actorId;
            this.freeActorId = freeActorId;
            this.freeFilmId = freeFilmId;
        }

        public DataXml ToDataXml() => new DataXml(Films,Actors,filmId,actorId,freeActorId,freeFilmId);

        public int GetActorId()
        {
            if (freeActorId.Count != 0)
                return freeActorId.Pop();
            return actorId++;
        }

        public int GetFilmId()
        {
            if (freeFilmId.Count != 0)
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

    public class DataXml
    {
        public List<Film> FilmsList { get; set; }
        public List<Actor> ActorsList { get; set; }

        public int FilmId;
        public int ActorId;
        public List<int> FreeActorId;
        public List<int> FreeFilmId;

        public DataXml()
        {
            FilmsList = new List<Film>();
            ActorsList = new List<Actor>();

            FreeActorId = new List<int>();
            FreeFilmId = new List<int>();
        }

        public DataXml(Dictionary<int, Film> films, Dictionary<int, Actor> actors,
            int filmId, int actorId, Stack<int> freeActorId, Stack<int> freeFilmId)
        {
            FilmsList = films.Select(x=> x.Value).ToList();
            ActorsList = actors.Select(x => x.Value).ToList();
            FilmId = filmId;
            ActorId = actorId;
            FreeActorId = freeActorId.ToList();
            FreeFilmId = freeFilmId.ToList();
        }

        public Data ToData() => new Data(FilmsList, ActorsList, FilmId, ActorId,
            new Stack<int>(FreeActorId), new Stack<int>(FreeFilmId));
    }
}
