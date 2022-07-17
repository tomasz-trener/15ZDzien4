using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaPogoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nazwaMiasta = "warszawa";
            string url = $"https://www.google.com/search?q=pogoda+{nazwaMiasta}";

            WebClient wc = new WebClient();
            string dane=  wc.DownloadString(url);

            //File.WriteAllText(@"c:\dane\15z\pogoda.html", dane);
            File.WriteAllText("c:\\dane\\15z\\pogoda.html", dane);


            char znakSzukany = '°';
            char znakKoncowy = '>';
            // char p = dane[0];// mozemy odwolac sie do konkretnego znaku w stringu 

            int indx= dane.IndexOf(znakSzukany);
            int aktualnaPozycja = indx;
            while (dane[aktualnaPozycja] != znakKoncowy)
                aktualnaPozycja--;

            // w tym momencie wiemy, ze aktualna pozycja 
            // wskazuje na miejsce znaku koncowe <
            int dlugosc = indx - aktualnaPozycja;
            string wynik= dane.Substring(aktualnaPozycja + 1, dlugosc + 1);
            Console.WriteLine(wynik);



            //indexOf

            //Console.WriteLine(dane);
            Console.ReadKey();

            

        }

        //https://github.com/tomasz-trener/15ZDzien3
        //https://github.com/tomasz-trener/15ZDzien4
    }
}
