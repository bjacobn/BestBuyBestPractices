using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;

namespace BestBuy_CRUD
{
    class Program
    {

        static void Main(string[] args)
        {
            //Connection string 
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");
            IDbConnection conn = new MySqlConnection(connString);

            Console.WriteLine("BestBuy - CRUD"); 
            MainMenu.Menu(conn);

        }
    }
}



