using System;
using System.Collections.Generic;
using System.Text;

namespace FilmData
{
    /// <summary>
    /// Работа в фильме
    /// </summary>
    public class Work
    {
        /// <summary>
        /// Id фильма
        /// </summary>
        public int FilmId { get; private set; }
        /// <summary>
        /// Id актера
        /// </summary>
        public int ActorId { get; private set; }
        /// <summary>
        /// Должность
        /// </summary>
        public Position Position { get; private set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Discription { get; private set; }

        public Work(int filmId, int actorId, Position position, string discription)
        {
            FilmId = filmId;
            ActorId = actorId;
            Position = position;
            Discription = discription;
        }
    }

    /// <summary>
    /// Должности
    /// </summary>
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
}
