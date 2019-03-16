using System;
using System.Collections.Generic;

namespace FilmData
{
    public class Film
    {

        public static List<string> FilmGenres = new List<string>() { };
        public DateTime Year { get;private set; }
        public string Name { get; private set; }
        public List<string> Ganres { get; private set; }
        public List<Actor> Actors { get; private set; }
        
    }
}
