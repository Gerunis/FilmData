using System;
using System.Collections.Generic;
using System.Text;

namespace FilmData
{
    public class Actor
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DOB { get; private set; }
        public Dictionary<Film, Tuple<Position, string>> Works { get; private set; }
        public byte[] Foto { get; private set; }
    }
}
