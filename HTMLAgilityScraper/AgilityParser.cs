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
    public class AgilityParser
    {
        string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=ParsingOfData;Integrated Security=True;
                     Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void Parsing()
        {
            string nasDaq = "https://www.nasdaq.com/markets/most-active.aspx";

            HtmlWeb nasDaqWeb = new HtmlWeb();
            HtmlDocument newDoc = nasDaqWeb.Load(nasDaq);

            HtmlNodeCollection stockTable = newDoc.DocumentNode.SelectNodes("//*[@id=\"_active\"]/table");

            List<ParseTable> ListOfStocks = new List<ParseTable>();

            foreach(var stock in stockTable)
            {
                DateTime stockRecord = DateTime.Now;
                string symbol = newDoc.DocumentNode.SelectSingleNode("").InnerText;
                string company = newDoc.DocumentNode.SelectSingleNode("").InnerText;
                string lastSale = newDoc.DocumentNode.SelectSingleNode("").InnerText;
                string pChg = newDoc.DocumentNode.SelectSingleNode("").InnerText;
                string volumeAvg = newDoc.DocumentNode.SelectSingleNode("").InnerText;



            }
            

        }

    }
}
