using System;
using System.Collections.Generic;
using System.Text;

namespace FilmData
{
    /// <summary>
    /// Класс актера
    /// </summary>
    public class Actor
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; private set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; private set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DOB { get; private set; }
        /// <summary>
        /// Список работ
        /// </summary>
        public List<Work> Works { get; private set; }
        /// <summary>
        /// Фото
        /// </summary>
        public byte[] Foto { get; private set; }
    }
}
