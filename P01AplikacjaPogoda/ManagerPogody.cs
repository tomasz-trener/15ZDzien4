using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaPogoda
{
    internal class ManagerPogody
    {
        //properties = Właściwosci  - cechy obiektu (bardziej rozbudowane o akcesory dostepu czyli get i set)
        //fields = pola - to samo co właściwosć czyli cechy obiektu 
        //methods = Metody - umiejetnosci danej klasy  czyli co dana klasa potrafi zrobic 
        //constructors = Konstruktory  - taka funkcja, ktora wywoluje podczas tworzenia obiektu czyli ona definiuje sposób tworzenia obuiektu 

        const string urlSzalbon = "https://www.google.com/search?q=pogoda+";
        const char znakSzukany = '°';
        const char znakKoncowy = '>';


        /// <summary>
        /// Pobiera temperature z serwisu GOOGLE 
        /// </summary>
        /// <param name="nazwaMiasta">Nazwa miasta, dla którego chcesz znaleźć temperature</param>
        /// <returns>Zwraca wartośc temepratury w stopniach Celcjusza</returns>
        public int PodajTemperature(string nazwaMiasta)
        {
            string url = urlSzalbon + nazwaMiasta;

            WebClient wc = new WebClient();
            string dane = wc.DownloadString(url);

            //File.WriteAllText(@"c:\dane\15z\pogoda.html", dane);
            //File.WriteAllText("c:\\dane\\15z\\pogoda.html", dane);
            // char p = dane[0];// mozemy odwolac sie do konkretnego znaku w stringu 

            int indx = dane.IndexOf(znakSzukany);
            int aktualnaPozycja = indx;
            while (dane[aktualnaPozycja] != znakKoncowy)
                aktualnaPozycja--;

            // w tym momencie wiemy, ze aktualna pozycja 
            // wskazuje na miejsce znaku koncowe <
            int dlugosc = indx - aktualnaPozycja;
            string wynik = dane.Substring(aktualnaPozycja + 1, dlugosc + 1 -2);

            return Convert.ToInt32(wynik);
        }


    }
}
