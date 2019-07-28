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
            AgilityParser newParse = new AgilityParser();
            newParse.Parsing();
        }
    }
}
