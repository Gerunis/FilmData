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
        /// Id актера
        /// </summary>
        public int Id { get;  set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get;  set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get;  set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime Dob { get;  set; }
        /// <summary>
        /// Список работ
        /// </summary>
        public List<Work> Works { get;  set; }
        /// <summary>
        /// Фото
        /// </summary>
        public byte[] Foto { get;  set; }

        public string Name => FirstName + " " + LastName;

        public override string ToString()
        {
            return Name + " " + Dob.ToString("yyyy.MM.dd");
        }

        public Actor() { }

        public Actor(Data data, string firstName, string lastName, DateTime dob, byte[] foto)
        {
            Id = data.GetActorId();
            FirstName = firstName;
            LastName = lastName;
            Dob = dob;
            Foto = foto;
            Works = new List<Work>();
        }

        public void AddWork(Work work)
        {
            Works.Add(work);
        }

        public IEnumerable<Work> GetWorks()
        {
            foreach (var work in Works)
                yield return work;
        }

        public void RemoveWork(Work work)
        {
            Works.Remove(work);
        }
    }
}
