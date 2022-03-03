using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace BestBuy_CRUD
{
    public static class MainMenu
    {
        public static void Menu(IDbConnection conn)
        {
            //Navigation Menu
            Console.WriteLine("Please select a number from the options below.");
            Console.WriteLine("1.) View all products");
            Console.WriteLine("2.) Create a new product");
            Console.WriteLine("3.) Update an exsiting product");
            Console.WriteLine("4.) Delete a product ");
            Console.WriteLine("5.) Exit\n");

            var input = Console.ReadLine();
            var answer = Convert.ToInt32(input);


            //Read 
            if (answer == 1)
            {
                ViewProducts.InventoryList(conn);
            }


            //Create 
            if (answer == 2)
            {
                
                var create = new DapperProductRepository(conn);
                Console.WriteLine();

                Console.WriteLine("What is the name of the new product??");
                var name = Console.ReadLine();

                Console.WriteLine("What is the price?");
                var price = double.Parse(Console.ReadLine());

                Console.WriteLine("What is the category?");
                var category = int.Parse(Console.ReadLine());

                create.CreateProduct(name, price, category);

                Console.WriteLine();
                Console.WriteLine($"{name} was added to the database.");
                TimeStamp.Date();

                ExitOption.MenuOrExitKey(conn);
            }


            //Update
            if (answer == 3)
            {
                Console.WriteLine();

                var update = new DapperProductRepository(conn);

                Console.WriteLine();

                ViewProducts.InventoryList(conn);

                Console.WriteLine();

                Console.WriteLine("What productID would you like to update?");
                var prodID = int.Parse(Console.ReadLine());

                Console.WriteLine("What is the new product name?");
                var newName = (Console.ReadLine());

                update.UpdateProduct(prodID, newName);

                Console.WriteLine($"ProductID {prodID} was updated to {newName}");
                TimeStamp.Date();

                ExitOption.MenuOrExitKey(conn);
            }


            //Delete 
            if (answer == 4)
            {
                var delete = new DapperProductRepository(conn);

                Console.WriteLine();

                ViewProducts.InventoryList(conn);

                Console.WriteLine();

                Console.WriteLine("What is the productID you would like delete?");
                var prodID = int.Parse(Console.ReadLine());

                delete.DeleteProduct(prodID);

                Console.WriteLine();

                Console.WriteLine($"ProductID {prodID} was deleted");
                TimeStamp.Date();

                ExitOption.MenuOrExitKey(conn);
            }


            //Exit
            if (answer == 5)
            {
                Console.WriteLine("Exiting BestBuy CRUD.");
                Environment.Exit(0);
            }

        }         
    }   
}
