using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }


        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Iznajmi_Click(object sender, EventArgs e)
        {
            ImeProzor.Text = "Pregedaj filmove";
            this.Prozori.Controls.Clear();
            Pregledaj pregledaj = new Pregledaj()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.Prozori.Controls.Add(pregledaj);
            pregledaj.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ImeProzor.Text = "Iznajmi";
            this.Prozori.Controls.Clear();
            iznajmi inzajmi = new iznajmi()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.Prozori.Controls.Add(Pregledaj);
            Pregledaj.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ImeProzor.Text = "vrati";
            this.Prozori.Controls.Clear();
            vrati vrati  = new vrati()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.Prozori.Controls.Add(vrati);
            vrati.Show();
        }
    }
}
