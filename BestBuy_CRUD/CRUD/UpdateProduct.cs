using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using BestBuy_CRUD.EndApp;
using MySql.Data.MySqlClient;

namespace BestBuy_CRUD
{
    public static class UpdateProduct
    {
        
        public static void Update(IDbConnection conn)
        {
            
            var update = new DapperProductRepository(conn);
            Console.WriteLine();

            ReadProducts.InventoryList(conn);

            Console.WriteLine();
            Console.WriteLine("What productID name would you like to update?");
            var prodID = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the new product name?");
            var newName = (Console.ReadLine());
            Console.WriteLine();

            update.UpdateProduct(prodID, newName);

            Console.WriteLine($"ProductID {prodID} name was updated to {newName}");
            
        }
    }
}
