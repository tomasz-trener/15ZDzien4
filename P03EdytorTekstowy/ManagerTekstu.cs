using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03EdytorTekstowy
{
    internal class ManagerTekstu
    {

        public string NaDuze(string tekst)
        {
            return tekst.ToUpper();
        }

        public string NaMale(string tekst)
        {
            return tekst.ToLower();
        }


        public string[] Policz(string tekst, string wyrazSzukany)
        {
            tekst =NaMale(tekst);
            wyrazSzukany = NaMale(wyrazSzukany);

            tekst = tekst.Replace("\n", " "); // zamienia znak nowej lini na spacje
            tekst = tekst.Replace("\r", " ");
            tekst = tekst.Replace(".", " ");


            string[] wyrazy=  tekst.Split(' ');
            //int suma = 0;

            List<string> listaWyszukanychWyrazow = new List<string>();


            foreach (var w in wyrazy)
                if (w.Contains(wyrazSzukany))
                    listaWyszukanychWyrazow.Add(w);
                   // suma++;
                 
            return listaWyszukanychWyrazow.ToArray();
        }
    }
}
