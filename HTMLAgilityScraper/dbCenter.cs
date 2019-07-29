using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HtmlAgilityPack;
using HTMLAgilityScraper.Agility;

namespace HTMLAgilityScraper
{
    public class dbCenter 
    {

        string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=ParsingOfData;Integrated Security=True;
                     Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void InsertDataToTable(ParseTable newStocks)
        {

            using (SqlConnection db = new SqlConnection(connectionString))
            {

            }
        }

    }
}
