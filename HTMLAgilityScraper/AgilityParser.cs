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

        public void consoleStockInput()
        {

            string marketSummary = "https://www.marketwatch.com/markets/us?mod=markets";

            HtmlWeb newStockPage = new HtmlWeb();
            HtmlDocument newDoc = newStockPage.Load(marketSummary);

            HtmlNodeCollection stockTable = newDoc.DocumentNode.SelectNodes("/html/body/div[4]/div[1]/div[1]/div/div/table");

            foreach(var element in stockTable)
            {
                var stocks = element.InnerText.ToString();
                Console.WriteLine(stocks);
            }
        }

        public void stockDataImplementation()
        {
            /*

            List<ParseTable> ListOfStocks = new List<ParseTable>();

            foreach (var stock in stockTable)
            {
                DateTime stockRecord = DateTime.Now;

                string symbol = stock.SelectSingleNode("/html/body/div[4]/div/main/div/article/div[2]/div/section[2]/div/div/div[2]/div[4]/table/tbody/tr[1]/th").InnerText;
                string company = stock.SelectSingleNode("/html/body/div[4]/div/main/div/article/div[2]/div/section[2]/div/div/div[2]/div[4]/table/tbody/tr[1]/td[1]").InnerText;
                string lastSale = stock.SelectSingleNode("/html/body/div[4]/div/main/div/article/div[2]/div/section[2]/div/div/div[2]/div[4]/table/tbody/tr[1]/td[2]/a").InnerText;
                string change = stock.SelectSingleNode("/html/body/div[4]/div/main/div/article/div[2]/div/section[2]/div/div/div[2]/div[4]/table/tbody/tr[1]/td[3]").InnerText;
                string pChg = stock.SelectSingleNode("/html/body/div[4]/div/main/div/article/div[2]/div/section[2]/div/div/div[2]/div[4]/table/tbody/tr[1]/td[4]").InnerText;

                ParseTable Stocks = new ParseTable();
                Stocks.StockRecord = stockRecord;
                Stocks.Symbol = symbol;
                Stocks.Company = company;
                Stocks.LastSale = lastSale;
                Stocks.Change = change;
                Stocks.PChg = pChg;
                ListOfStocks.Add(Stocks);

                InsertDataToTable(Stocks);
            
            }
            */
        }

    }
}     
