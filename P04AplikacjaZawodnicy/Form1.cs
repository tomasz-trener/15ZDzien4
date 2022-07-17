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

namespace P04AplikacjaZawodnicy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] dane = File.ReadAllLines(ofd.FileName);

                //lbDane.Items.Clear();
                //foreach (var w in dane)
                //    lbDane.Items.Add(w);

                ManagerZawodnikow mz = new ManagerZawodnikow(txtKraj.Text);
                Zawodnik[] zawodnicy = mz.Wczytaj(dane);

                lbDane.DataSource = zawodnicy;
                lbDane.DisplayMember = "WidoczneDane";

                lblLicznaZaimportowanychDanych.Text = Convert.ToString(zawodnicy.Length);
            }

           
        }
    }
}
