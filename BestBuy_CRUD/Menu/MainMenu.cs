using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace BestBuy_CRUD
{
    public static class MainMenu
    {
        public static void UserInput(IDbConnection conn)
        {
            //UserInput Selects CRUD Execution
            Console.WriteLine("BestBuy - CRUD");
            Console.WriteLine("Please select a number from the options below.");
            Console.WriteLine("1.) View all products.");
            Console.WriteLine("2.) Create a new product.");
            Console.WriteLine("3.) Update an exsiting product name.");
            Console.WriteLine("4.) Delete a product.");
            Console.WriteLine("5.) Exit\n");        
        }
    }
}
