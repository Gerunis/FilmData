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
    public partial class ActorForm : Form
    {
        public ActorForm(Data data, Actor actor)
        {
            InitializeComponent();
            foreach (var work in actor.Works)
            {
                listBox1.Items.Add(data.Films[work.FilmId] + " " + work);
            }

            FirstName.Text = actor.FirstName;
            LastName.Text = actor.LastName;
            DOB.Text = actor.Dob.ToString("dd.MM.yyyy");
            if(actor.Foto != null)
                using (var ms = new MemoryStream(actor.Foto))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
        }
    }
}
