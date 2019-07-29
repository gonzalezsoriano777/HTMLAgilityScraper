using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Data.SqlClient;
using HTMLAgilityScraper.Agility;

namespace HTMLAgilityScraper
{
    public class AgilityParser : dbCenter
    {
        
        public void Parsing()
        {
            string nasDaq = "https://www.nasdaq.com/markets/most-active.aspx";

            HtmlWeb nasDaqWeb = new HtmlWeb();
            HtmlDocument newDoc = nasDaqWeb.Load(nasDaq);

            HtmlNodeCollection stockTable = newDoc.DocumentNode.SelectNodes("//*[@id=\"_active\"]/table/tr");

            List<ParseTable> ListOfStocks = new List<ParseTable>();
            foreach (var stock in stockTable)
            {
                DateTime stockRecord = DateTime.Now;
                string symbol = stock.SelectSingleNode("td[1]/h3/a").InnerText;
                string company = stock.SelectSingleNode("td[2]/b/a").InnerText;
                string lastSale = stock.SelectSingleNode("td[4]").InnerText;
                string pChg = stock.SelectSingleNode("td[5]/span").InnerText;
                string volumeAvg = stock.SelectSingleNode("td[6]").InnerText;

                ParseTable newStocks = new ParseTable();
                newStocks.StockRecord = stockRecord;
                newStocks.Symbol = symbol;
                newStocks.Company = company;
                newStocks.LastSale = lastSale;
                newStocks.PChg = pChg;
                newStocks.VolumeAvg = volumeAvg;

                ListOfStocks.Add(newStocks);
            }
        }     
    }
}
