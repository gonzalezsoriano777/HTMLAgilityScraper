using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Data.SqlClient;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using HTMLAgilityScraper.Agility;

namespace HTMLAgilityScraper
{
    public class AgilityParser : dbCenter
    {

        public void navigateToFinancePage()
        {
            /*
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--headless");
            option.AddArgument("window-size=1200,1100");
            */

            using(IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://www.google.com/");

                WebDriverWait signIn = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                signIn.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"gb_70\"]")));

                IWebElement signInButton = driver.FindElement(By.XPath("//*[@id=\"gb_70\"]"));

                signInButton.Click();

                IWebElement email = driver.FindElement(By.Id("identifierId"));

                email.SendKeys("hectorgonzalez.student@careerdevs.com");
                email.SendKeys(Keys.Enter);

                WebDriverWait passwordDuration = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                passwordDuration.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"password\"]/div[1]/div/div[1]/input")));

                IWebElement password = driver.FindElement(By.XPath("//*[@id=\"password\"]/div[1]/div/div[1]/input"));

                password.SendKeys("Hector346321");
                password.SendKeys(Keys.Enter);

                driver.Navigate().GoToUrl("https://google.com/finance");
            }

        }

        public void grabAndPrintStockToConsole()
        {

        }

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
                */
    }
}     
