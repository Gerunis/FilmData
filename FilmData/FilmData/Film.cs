using System;
using System.Collections.Generic;

namespace FilmData
{
    public class Film
    {
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

        public static List<string> FilmsCountries = new List<string>()
        {

        };
        public string Name { get; private set; }
        public List<string> Genres { get; private set; }
        public DateTime Year { get; private set; }
        public List<string> Countries { get; private set; }
        public DateTime Duration { get; private set; }
        public AgeRating AgeRating { get; private set; }
        public Dictionary<Actor,Tuple<Position, string>> Credits { get; private set; }
        public byte[] Poster { get; private set; }
        
    }

    public enum Position
    {
        Actor,
        Director,
        Writer,
        Producer,
        Operator,
        Composer,
        Editor,
        Other
    }

    public enum AgeRating
    {
        PG,
        PG13,
        R,
        NC17
    }
}
