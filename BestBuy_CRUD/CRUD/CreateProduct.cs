using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using BestBuy_CRUD.EndApp;
using MySql.Data.MySqlClient;

namespace BestBuy_CRUD
{
    public static class CreateProduct
    {

        public static void Create(IDbConnection conn)
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
            Console.WriteLine($"{name} was added to the inventory."
                );
            TimeStamp.Date();

            Message.MenuExit(conn);


        }
    }
}
