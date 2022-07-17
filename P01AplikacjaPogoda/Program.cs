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
            while (true)
            {
                Console.WriteLine("podaj nazwę miasta");
                string nazwaMiasta = Console.ReadLine();

                ManagerPogody mp = new ManagerPogody();

                try
                {
                    int wynik = mp.PodajTemperature(nazwaMiasta);
                    Console.WriteLine(wynik);
                }
                catch (Exception)
                {
                    Console.WriteLine("Nie udało sie pobrać temperatury");
                }
               
            }






            //indexOf

            //Console.WriteLine(dane);
            // Console.ReadKey();



        }

        //https://github.com/tomasz-trener/15ZDzien3
        //https://github.com/tomasz-trener/15ZDzien4
    }
}
