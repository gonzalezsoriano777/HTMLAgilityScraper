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

        /*
         Will print each input to the console (nodes for db)
         */

    public class AgilityParser : dbCenter
    {

        public void stockDataImplementation()
        {

            string marketSummary = "https://www.marketwatch.com/markets/us?mod=markets";

            HtmlWeb newStockPage = new HtmlWeb();
            HtmlDocument newDoc = newStockPage.Load(marketSummary);

            HtmlNodeCollection stockTable = newDoc.DocumentNode.SelectNodes("/html/body/div[4]/div[1]/div[1]/div/div/table/tbody");

            /*

            List<ParsingTable> ListOfStocks = new List<ParsingTable>();

            foreach (var stock in stockTable)
            {
                DateTime stockRecord = DateTime.Now;

                string ticker = stock.SelectSingleNode("/html/body/div[4]/div[1]/div[1]/div/div/table/tbody/tr[1]/td[1]/a").InnerText;
                string company = stock.SelectSingleNode("/html/body/div[4]/div[1]/div[1]/div/div/table/tbody/tr[1]/td[2]/a").InnerText;
                string lastSale = stock.SelectSingleNode("/html/body/div[4]/div[1]/div[1]/div/div/table/tbody/tr[1]/td[3]/bg-quote").InnerText;
                string change = stock.SelectSingleNode("/html/body/div[4]/div[1]/div[1]/div/div/table/tbody/tr[1]/td[4]/bg-quote").InnerText;
                string pChg = stock.SelectSingleNode("/html/body/div[4]/div[1]/div[1]/div/div/table/tbody/tr[1]/td[5]/bg-quote").InnerText;

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

    */
        }

    }
}     
