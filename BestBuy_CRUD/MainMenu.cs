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
            Console.WriteLine("Please choose a number from the options below:");
            Console.WriteLine("1.) View all products");
            Console.WriteLine("2.) Create a new product");
            Console.WriteLine("3.) Update an exsiting product");
            Console.WriteLine("4.) Delete a product ");
            Console.WriteLine("5.) Exit\n");

            string input = Console.ReadLine();
            var answer = Convert.ToInt32(input);

            


            //Read 
            if (answer == 1)
            {
                var repo = new DapperProductRepository(conn);
                var products = repo.GetAllProducts();

                foreach (var item in products)
                {
                    Console.WriteLine($"{item.ProductID} {item.Name}");
                }

                TimeStamp.Date();

                ExitOption.MenuOrExitKey(conn);
            }


            //Create 
            if (answer == 2)
            {
                var create = new DapperProductRepository(conn);

                Console.WriteLine("What is the name of the new product??");
                var name = Console.ReadLine();

                Console.WriteLine("What is the price?");
                var price = double.Parse(Console.ReadLine());

                Console.WriteLine("What is the category?");
                var category = int.Parse(Console.ReadLine());

                create.CreateProduct(name, price, category);

                Console.WriteLine($"{name} was added to the inventory");

                ExitOption.MenuOrExitKey(conn);
            }


            //Update
            if (answer == 3)
            {
                var update = new DapperProductRepository(conn);

                var products = update.GetAllProducts();

                foreach (var item in products)
                {
                    Console.WriteLine($"{item.ProductID} {item.Name}");
                }

                Console.WriteLine();

                Console.WriteLine("What product ID would you like to update?");
                var prodID = int.Parse(Console.ReadLine());

                Console.WriteLine("What is the new product name?");
                var newName = (Console.ReadLine());

                update.UpdateProduct(prodID, newName);

                Console.WriteLine($"Product ID # {prodID} name was updated to {newName}");

                ExitOption.MenuOrExitKey(conn);
            }


            //Delete 
            if (answer == 4)
            {
                var delete = new DapperProductRepository(conn);

                var products = delete.GetAllProducts();

                foreach (var item in products)
                {
                    Console.WriteLine($"{item.ProductID} {item.Name}");
                }

                Console.WriteLine();

                Console.WriteLine("Please select the productID number you would like to delete?");
                var prodID = int.Parse(Console.ReadLine());

                delete.DeleteProduct(prodID);

                Console.WriteLine($"ProductID {prodID} was deleted\n");

                ExitOption.MenuOrExitKey(conn);
            }


            //Exit
            if (answer == 5)
            {
                Environment.Exit(0);
            }

        }         
    }   
}
