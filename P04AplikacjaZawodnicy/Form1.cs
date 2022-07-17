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
            string[] dane= File.ReadAllLines(@"C:\dane\15Z\zawodnicy.txt");

            //lbDane.Items.Clear();
            //foreach (var w in dane)
            //    lbDane.Items.Add(w);

            ManagerZawodnikow mz = new ManagerZawodnikow();
            Zawodnik[] zawodnicy= mz.Wczytaj(dane);

            lbDane.DataSource= zawodnicy;
        }
    }
}
