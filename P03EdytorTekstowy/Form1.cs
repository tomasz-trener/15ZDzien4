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

namespace P03EdytorTekstowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            string dane = File.ReadAllText(txtSciezka.Text);
            txtDane.Text = dane;
        }

        private void txtSciezka_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pliki tekstowe (*.txt)|*.txt";

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                txtSciezka.Text=ofd.FileName;
            }
        }
    }
}
