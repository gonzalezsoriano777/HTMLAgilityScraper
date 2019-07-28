using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Data.SqlClient;

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
            HtmlDocument newDocument = nasDaqWeb.Load(nasDaq);


            using (SqlConnection db = new SqlConnection(connectionString))
            {

            }

        }

    }
}
