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

namespace P02AplikacjaPogodaUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] wiersze= File.ReadAllLines("miasta.txt");

            for (int i = 0; i < wiersze.Length; i++)
                cbMiasta.Items.Add(wiersze[i]);
        }

        private void btnPodajTemeprature_Click(object sender, EventArgs e)
        {
            WczytajTemperature();
        }

        private void txtNazwaMiasta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                WczytajTemperature();
        }

        private void WczytajTemperature()
        {
            ManagerPogody mp = new ManagerPogody();

            try
            {
                int temp = mp.PodajTemperature(txtNazwaMiasta.Text);
                MessageBox.Show(Convert.ToString(temp), "Temperatura", MessageBoxButtons.OK, MessageBoxIcon.Information);

                File.AppendAllText("miasta.txt", txtNazwaMiasta.Text + Environment.NewLine);
            
            
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd pobierania temperatury", "Temperatura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMiasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string wybraneMiasto = cbMiasta.SelectedText;
            txtNazwaMiasta.Text = wybraneMiasto;
            WczytajTemperature();
        }

        //przerwa 10:50
    }
}
