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
    public partial class AddActorForm : Form
    {
        public Actor Actor;
        private Data data;

        public AddActorForm(Data data)
        {
            this.data = data;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] photo = null;
            if (pictureBox1.Image != null)
            {
                var stream = new MemoryStream();
                pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
                photo = stream.ToArray();
            }
            Actor = new Actor(data, FirstName.Text, LastName.Text, dateTimePicker1.Value, photo);
        }

        private void PhotoButtonClick(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Фотография|*.jpg" };
            var dr = ofd.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
