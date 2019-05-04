using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmData.UI
{
    public partial class ChooseActorForm : Form
    {
        private Data data;
        public Work Work { get; set; }
        public ChooseActorForm(Data data)
        {
            this.data = data;
            InitializeComponent();
            dataBindingSource1.DataSource = data.Actors.Select(x => x.Value).ToList();
            comboBox1.DataSource = dataBindingSource1.DataSource;
            comboBox1.DisplayMember = "Name";

            comboBox2.DataSource = Enum.GetValues(typeof(Position));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == null)
                MessageBox.Show(
                    "Актер не выбран. Добавьте актера.",
                    "Нет актера.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            else
            {
                Work = new Work(data, ((Actor)comboBox1.SelectedItem).Id, (Position)comboBox2.SelectedItem, textBox1.Text);
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ff = new AddActorForm(data);
            if (ff.ShowDialog(this) == DialogResult.OK)
            {
                data.Actors[ff.Actor.Id] = ff.Actor;
                dataBindingSource1.DataSource = data.Actors.Select(x => x.Value).ToList();
                comboBox1.DataSource = dataBindingSource1.DataSource;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
