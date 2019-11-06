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

    /*
     * Stock Input
     * Ticker
     * Name
     * Last Price
     * Change
     * Percent Change
     */

    public class AgilityParser : dbCenter
    {

        public void stockDataImplementation()
        {

            string marketSummary = "https://www.marketwatch.com/markets/us?mod=markets";

            HtmlWeb newStockPage = new HtmlWeb();
            HtmlDocument newDoc = newStockPage.Load(marketSummary);

            HtmlNodeCollection stockTable = newDoc.DocumentNode.SelectNodes("/html/body/div[4]/div[1]/div[1]/div/div/table");

            List<ParseTable> ListOfStocks = new List<ParseTable>();

            foreach (var stock in stockTable)
            {
                DateTime stockRecord = DateTime.Now;

                string ticker = stock.SelectSingleNode("").InnerText;
                string company = stock.SelectSingleNode("").InnerText;
                string lastSale = stock.SelectSingleNode("").InnerText;
                string change = stock.SelectSingleNode("").InnerText;
                string pChg = stock.SelectSingleNode("").InnerText;

                ParseTable Stocks = new ParseTable();
                Stocks.StockRecord = stockRecord;
                Stocks.Ticker = ticker;
                Stocks.Company = company;
                Stocks.LastSale = lastSale;
                Stocks.Change = change;
                Stocks.PChg = pChg;
                ListOfStocks.Add(Stocks);

                InsertDataToTable(Stocks);
            
            }
        }

    }
}     
