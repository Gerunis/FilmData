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
        public int FilmId { get; set; }
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

        private string actorName;

        public Work(Data data, int actorId, Position position, string discription)
        {
            actorName = data.Actors[actorId].Name;
            ActorId = actorId;
            Position = position;
            Discription = discription;
        }

        public override string ToString()
        {
            return actorName + " " + Position + " " + Discription;
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
