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
        /// Фильм
        /// </summary>
        public Film Film { get; private set; }
        /// <summary>
        /// Актер
        /// </summary>
        public Actor Actor { get; private set; }
        /// <summary>
        /// Должность
        /// </summary>
        public Position Position { get; private set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; private set; }
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
