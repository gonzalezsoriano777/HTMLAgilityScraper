using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace HTMLAgilityScraper
{
   public class AgilityScrape
    {
        static void Main(string[] args)
        {


            AgilityParser dbStocker = new AgilityParser();
            dbStocker.stockDataImplementation();
        }
    }
}
