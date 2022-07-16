using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ScrapeLib;

namespace ClientLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape MyScrape = new Scrape();
            string value = MyScrape.ScrapeWebpage("https://Google.com");
            Console.WriteLine(value);
        }
    }
}

