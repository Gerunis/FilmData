using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmData.UI
{
    public partial class AddFilmForm : Form
    {
        private Data data;
        public Film Film;

        public AddFilmForm(Data data)
        {
            this.data = data;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Фотография|*.jpg" };
            var dr = ofd.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            byte[] poster = null;
            if (pictureBox1.Image != null)
            {
                var stream = new MemoryStream();
                pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
                poster = stream.ToArray();
            }

            AgeRating ageRating = AgeRating.NC17;
            if(comboBox1.SelectedItem != null)
            Enum.TryParse(comboBox1.SelectedItem.ToString(), out ageRating);
            Film = new Film(data, filmName.Text, primierDate.Value, duration.Value,
                ageRating, poster, null, countrie.Text);
            foreach (var w in listBox1.Items)
            {
                var work = (Work) w;
                work.FilmId = Film.Id;
                Film.Credits.Add(work);
                data.Actors[work.ActorId].Works.Add(work);
            }
        }

        private void CancelButtom_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CustAdd_Click(object sender, EventArgs e)
        {
            var ff = new ChooseActorForm(data);
            if (ff.ShowDialog(this) == DialogResult.OK)
            {
                listBox1.Items.Add(ff.Work);
            }
        }

        private void CustRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
