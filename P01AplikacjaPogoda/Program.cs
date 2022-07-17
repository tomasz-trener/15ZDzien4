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

            File.WriteAllText(@"c:\dane\15z\pogoda.html", dane);

        }
    }
}
