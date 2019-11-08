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
        string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog = ParsingOfData; Integrated Security = True; " +
            "Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void InsertDataToTable(ParsingTable Stocks)
        {
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                string insert = "INSERT INTO dbo.ParsingTable ( StockRecord, Ticker, Company, LastSale, Change, PChg) VALUES (@stockRecord, @ticker, @company, @lastSale, @change, @pChg)";
                {
                    db.Open();
                    Console.WriteLine("Database has been opened");
                    Console.WriteLine();

                    using(SqlCommand dataToTable = new SqlCommand(insert, db))
                    {
                        dataToTable.Parameters.AddWithValue("@stockRecord", Stocks.StockRecord).ToString();
                        dataToTable.Parameters.AddWithValue("@ticker", Stocks.Ticker).ToString();
                        dataToTable.Parameters.AddWithValue("@company", Stocks.Company).ToString();
                        dataToTable.Parameters.AddWithValue("@lastSale", Stocks.LastSale).ToString();
                        dataToTable.Parameters.AddWithValue("@change", Stocks.Change).ToString();
                        dataToTable.Parameters.AddWithValue("@pChg", Stocks.PChg).ToString();

                        dataToTable.ExecuteNonQuery();
                    }

                    db.Close();
                    Console.WriteLine("Database table has been inserted with data");

                } 

            }
        }

    }
}
