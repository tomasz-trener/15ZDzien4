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

            AktualizujMiasta();
        }

        private void AktualizujMiasta()
        {
            string[] wiersze = File.ReadAllLines("miasta.txt");

            cbMiasta.Items.Clear();

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
                // wczytywanie temepratury z google
                int temp = mp.PodajTemperature(txtNazwaMiasta.Text);
                MessageBox.Show(Convert.ToString(temp), "Temperatura", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // uzupełniamy lokalny plik tekstowy i wyszukane miasto
                string[] miasta= File.ReadAllLines("miasta.txt");
                // przy okazji sprawdzamy, czy juz wczenij ktos nie uzyl tego miasta bo nie chcemy duplikatów
                string miasto = txtNazwaMiasta.Text;
                // ujednolicamy wielkoc liter tak aby pierwsza literka byla duza pozpostale male 
                miasto = miasto.Substring(0, 1).ToUpper() + miasto.Substring(1).ToLower();
               
                if (!miasta.Contains(miasto) && miasto != "")
                    File.AppendAllText("miasta.txt", miasto + Environment.NewLine);

                // zaktualizj nasza liste rozwijana o nowe miasto, które zostało dodane do naszej loklanej bazy danch miast
                AktualizujMiasta();


            }
            catch (Exception)
            {
                MessageBox.Show("Błąd pobierania temperatury", "Temperatura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMiasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string wybraneMiasto = cbMiasta.Text;
            txtNazwaMiasta.Text = wybraneMiasto;
            WczytajTemperature();
        }

        //przerwa 10:50
    }
}
