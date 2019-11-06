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

        public void InsertDataToTable(ParseTable Stocks)
        {
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                string insert = "INSERT INTO dbo.ParsingTable ( StockRecord, Symbol, Company, LastSale, Change, PChg) VALUES (@stockRecord, @symbol, @company, @lastSale, @change, @pChg)";
                {
                    db.Open();
                    Console.WriteLine("Database has been opened");
                    Console.WriteLine();

                    using(SqlCommand dataToTable = new SqlCommand(insert, db))
                    {
                        dataToTable.Parameters.AddWithValue("@stockRecord", Stocks.StockRecord);
                        dataToTable.Parameters.AddWithValue("@symbol", Stocks.Ticker);
                        dataToTable.Parameters.AddWithValue("@company", Stocks.Company);
                        dataToTable.Parameters.AddWithValue("@lastSale", Stocks.LastSale);
                        dataToTable.Parameters.AddWithValue("@change", Stocks.Change);
                        dataToTable.Parameters.AddWithValue("@pChg", Stocks.PChg);

                        dataToTable.ExecuteNonQuery();
                    }

                    db.Close();
                    Console.WriteLine("Database has been inserted with data");

                } 

            }
        }

    }
}
