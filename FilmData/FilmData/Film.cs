using System;
using System.Collections.Generic;

namespace FilmData
{
    /// <summary>
    /// Класс фильма
    /// </summary>
    public class Film
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
        public static List<string> FilmsCountries = new List<string>()
        {

        };
        /// <summary>
        /// Название фильма
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Жанры фильма
        /// </summary>
        public List<string> Genres { get; private set; }
        /// <summary>
        /// Год выпуск
        /// </summary>
        public DateTime Year { get; private set; }
        /// <summary>
        /// Страны производства
        /// </summary>
        public List<string> Countries { get; private set; }
        /// <summary>
        /// Продолжительность
        /// </summary>
        public DateTime Duration { get; private set; }
        /// <summary>
        /// Возростной рейтинг
        /// </summary>
        public AgeRating AgeRating { get; private set; }
        /// <summary>
        /// Актеры и съемочная команда
        /// </summary>
        public List<Work> Credits { get; private set; }
        /// <summary>
        /// Постер
        /// </summary>
        public byte[] Poster { get; private set; }
        
    }

    /// <summary>
    /// Возростные рейтинги
    /// </summary>
    public enum AgeRating
    {
        PG,
        PG13,
        R,
        NC17
    }
}
