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

      /*
        Will print each input to the console (nodes for db)
      */

    public class AgilityParser : dbCenter
    {
        public void stockDataImplementation()
        {
            string stockMarket = "https://www.marketwatch.com/investing/index/comp?mod=us-markets";

            HtmlWeb stockWebsite = new HtmlWeb();
            HtmlDocument stockDoc = stockWebsite.Load(stockMarket);

            HtmlNodeCollection stockTable = stockDoc.DocumentNode.SelectNodes("/html/body/div[1]/div[5]/div[3]/div[1]/div/table/tbody");
    
            List<ParsingTable> ListOfStocks = new List<ParsingTable>();

            foreach (HtmlNode stock in stockTable)
            {
                DateTime stockRecord = DateTime.Now;
                var company = stock.SelectSingleNode("/html/body/div[1]/div[5]/div[3]/div[1]/div/table/tbody/tr[1]/td[1]").InnerText;
                var lastSale = stock.SelectSingleNode("/html/body/div[1]/div[5]/div[3]/div[1]/div/table/tbody/tr[1]/td[2]").InnerText;
                var change = stock.SelectSingleNode("/html/body/div[1]/div[5]/div[3]/div[1]/div/table/tbody/tr[1]/td[3]").InnerText;
                var percentChange = stock.SelectSingleNode("/html/body/div[1]/div[5]/div[3]/div[1]/div/table/tbody/tr[1]/td[4]").InnerText;

                ParsingTable Stocks = new ParsingTable();
                Stocks.StockRecord = stockRecord;
                Stocks.Company = company;
                Stocks.LastSale = lastSale;
                Stocks.Change = change;
                Stocks.PercentChange = percentChange;
                ListOfStocks.Add(Stocks);
  
                InsertDataToTable(Stocks);
            }

            
        
        }

    }
}     
