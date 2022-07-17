using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04AplikacjaZawodnicy
{
    internal class ManagerZawodnikow
    {
        public Zawodnik[] Wczytaj(string[] wiersze)
        {

            Zawodnik[] zawodnicy = new Zawodnik[wiersze.Length-1];

            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');

                Zawodnik z = new Zawodnik(komorki);
                //z.Id_zawodnika = Convert.ToInt32(komorki[0]);
                //z.Id_trenera = Convert.ToInt32(komorki[1]);
                //z.Imie = komorki[2];
                //z.Nazwisko = komorki[3];
                //z.Kraj = komorki[4];
                //z.DataUr = Convert.ToDateTime(komorki[5]);
                //z.Wzrost = Convert.ToInt32(komorki[6]);
                //z.Waga = Convert.ToInt32(komorki[7]);

                zawodnicy[i - 1] = z;
            }

            return zawodnicy;

        }


    }
}
