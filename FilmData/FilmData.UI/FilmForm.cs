using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmData.UI
{
    public partial class FilmForm : Form
    {
        public FilmForm(Data data, Film film)
        {
            InitializeComponent();
            foreach (var work in film.Credits)
            {
                listBox1.Items.Add(data.Actors[work.ActorId] + " " + work);
            }

            FilmName.Text = film.Name;
            Year.Text = film.Year.ToString("yyyy");
            Countrie.Text = film.Countrie;
            Duration.Text = film.Duration.ToString("hh:mm");
            Raiting.Text = film.AgeRating.ToString();
            if (film.Poster != null)
                using (var ms = new MemoryStream(film.Poster))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
        }
    }
}
