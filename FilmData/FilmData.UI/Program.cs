using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmData.UI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var e = new Data();
            e.Actors[1] = new Actor(e,"Иванов","efg1",DateTime.Now, null);
            e.Actors[2] = new Actor(e, "Петров", "efg2", DateTime.Now, null);
            e.Actors[3] = new Actor(e, "Васичкин", "efg3", DateTime.Now, null);
            e.Actors[4] = new Actor(e, "Иванова", "efg4", DateTime.Now, null);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(new Data()));
        }
    }
}
