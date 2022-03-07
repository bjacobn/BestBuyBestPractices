using BestBuy_CRUD.EndApp;
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
            
            //Menu
            MainMenu.UserInput(conn);

            //Users Input
            var input = Console.ReadLine();
            var answer = Convert.ToInt32(input);

            //Read 
            if (answer == 1)
            {
                ReadProducts.InventoryList(conn);
            }


            //Create 
            if (answer == 2)
            {
                CreateProduct.Create(conn);
            }


            //Update 
            if (answer == 3)
            {
                UpdateProduct.Update(conn);
            }


            //Delete 
            if (answer == 4)
            {
                DeleteProduct.Delete(conn);
            }


            //Exit Applicaiton
            if (answer == 5)
            {
                Console.WriteLine("Exiting BestBuy CRUD.");
                Environment.Exit(0);
            }

        }
    }
}



