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
        /// Id фильма
        /// </summary>
        public int Id { get; private set; }
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
        public string Countrie { get; private set; }
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

        public override string ToString()
        {
            return Name + " (" + Year.ToString("yyyy") + "). " + Countrie + '.';
        }

        public Film(Data data, string name, DateTime year, DateTime duration, AgeRating ageRating, byte[] poster,
            List<string> genres, string countrie)
        {
            Id = data.GetFilmId();
            Name = name;
            Year = year;
            Duration = duration;
            AgeRating = ageRating;
            Poster = poster;
            Genres = genres;
            Countrie = countrie;
            Credits = new List<Work>();
        }

        public void AddWork(Work work)
        {
            Credits.Add(work);
        }

        public IEnumerable<Work> GetCredits()
        {
            foreach (var work in Credits)
                yield return work;
        }

        public void RemoveWork(Work work)
        {
            Credits.Remove(work);
        }

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
