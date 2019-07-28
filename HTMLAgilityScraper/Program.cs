using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace HTMLAgilityScraper
{
    class AgilityScrape
    {
        static void Main(string[] args)
        {
            string nasDaq = "https://www.nasdaq.com/markets/most-active.aspx";

           HtmlWeb newScrape = new HtmlWeb();

            HtmlDocument doc = newScrape.Load(nasDaq);

            var node = doc.DocumentNode.SelectNodes("//*[@id=\"_active\"]/table").ToList();

            foreach(var item in node)
            {
                Console.WriteLine(item.InnerText);
            }
        }
    }
}
