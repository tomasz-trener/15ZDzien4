using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void btnPodajTemeprature_Click(object sender, EventArgs e)
        {
            ManagerPogody mp = new ManagerPogody();

            try
            {
                int temp = mp.PodajTemperature(txtNazwaMiasta.Text);
                MessageBox.Show(Convert.ToString(temp), "Temperatura", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Błąd pobierania temperatury", "Temperatura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
