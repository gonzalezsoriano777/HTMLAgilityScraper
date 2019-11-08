﻿using System;
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

            List<ParsingTable> ListOfStocks = new List<ParsingTable>();

            foreach (var stock in stockTable)
            {
                DateTime stockRecord = DateTime.Now;

                var ticker = stock.SelectSingleNode("/html/body/div[4]/div[1]/div[1]/div/div/table/tbody/tr[1]/td[1]").InnerText.ToString();
                var company = stock.SelectSingleNode("/html/body/div[4]/div[1]/div[1]/div/div/table/tbody/tr[1]/td[2]").InnerText.ToString();
                var lastSale = stock.SelectSingleNode("/html/body/div[4]/div[1]/div[1]/div/div/table/tbody/tr[1]/td[3]").InnerText.ToString();
                var change = stock.SelectSingleNode("/html/body/div[4]/div[1]/div[1]/div/div/table/tbody/tr[1]/td[4]").InnerText.ToString();
                var pChg = stock.SelectSingleNode("/html/body/div[4]/div[1]/div[1]/div/div/table/tbody/tr[1]/td[5]").InnerText.ToString();

                ParsingTable Stocks = new ParsingTable();
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
