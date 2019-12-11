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
        string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog = ParsingOfData; Integrated Security = True; 
                        Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void InsertDataToTable(ParsingTable Stocks)
        {
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                string insert = "INSERT INTO dbo.ParsingTable ( StockRecord, Company, LastSale, Change, PercentChange) VALUES (@stockRecord, @company, @lastSale, @change, @percentChange)";
                {
                    db.Open();
                    Console.WriteLine("Database has been opened");
                    Console.WriteLine();

                    using(SqlCommand dataToTable = new SqlCommand(insert, db))
                    {
                        dataToTable.Parameters.AddWithValue("@stockRecord", Stocks.StockRecord);
                        dataToTable.Parameters.AddWithValue("@company", Stocks.Company);
                        dataToTable.Parameters.AddWithValue("@lastSale", Stocks.LastSale);
                        dataToTable.Parameters.AddWithValue("@change", Stocks.Change);
                        dataToTable.Parameters.AddWithValue("@percentChange", Stocks.PercentChange);

                        dataToTable.ExecuteNonQuery();
                        

                        dataToTable.ExecuteNonQuery();
                    }

                    db.Close();
                    Console.WriteLine("Database table has been inserted with data");
                    Console.WriteLine();
                    Console.WriteLine("Database has been shut down");
                } 

            }
        }

    }
}
