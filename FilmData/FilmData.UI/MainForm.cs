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
using System.Xml.Serialization;

namespace FilmData.UI
{
    public partial class MainForm : Form
    {
        private Data data;
        public MainForm(Data data)
        {
            this.data = data;
            InitializeComponent();
            tabControl1.SelectedIndexChanged += ChangeTab;
            foreach (var actor in data.Actors)
            {
                listBox1.Items.Add(actor.Value);
            }
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;

            foreach (var film in data.Films)
            {
                listBox2.Items.Add(film.Value);
            }

            listBox2.MouseDoubleClick += listBox2_MouseDoubleClick;
        }


        private void ChangeTab(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (var actor in data.Actors)
            {
                listBox1.Items.Add(actor.Value);
            }

            foreach (var film in data.Films)
            {
                listBox2.Items.Add(film.Value);
            }
        }

        private void ActorAdd_Click(object sender, EventArgs e)
        {
            var ff = new AddActorForm(data);
            if (ff.ShowDialog(this) == DialogResult.OK)
            {
                data.Actors[ff.Actor.Id] = ff.Actor;
                listBox1.Items.Add(ff.Actor);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                var item = (Actor)listBox1.Items[index];
                var ff = new ActorForm(data, item);
                ff.ShowDialog(this);
            }
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox2.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                var item = (Film)listBox2.Items[index];
                var ff = new FilmForm(data, item);
                ff.ShowDialog(this);
            }
        }

        private void FilmAdd_Click(object sender, EventArgs e)
        {
            var ff = new AddFilmForm(data);
            if (ff.ShowDialog(this) == DialogResult.OK)
            {
                data.Films[ff.Film.Id] = ff.Film;
                listBox2.Items.Add(ff.Film);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Кино|*.filmdata" };

            if (sfd.ShowDialog(this) != DialogResult.OK)
                return;

            var xs = new XmlSerializer(typeof(DataXml));

            var file = File.Create(sfd.FileName);

            xs.Serialize(file, data.ToDataXml());
            file.Close();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Кино|*.filmdata" };

            if (ofd.ShowDialog(this) != DialogResult.OK)
                return;
            var xs = new XmlSerializer(typeof(DataXml));
            var file = File.OpenRead(ofd.FileName);
            data = ((DataXml)xs.Deserialize(file)).ToData();
            file.Close();
            ChangeTab(null,null);
        }
    }
}
