using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using BestBuy_CRUD.EndApp;
using MySql.Data.MySqlClient;

namespace BestBuy_CRUD
{
    public static class DeleteProduct
    {
 
        public static void Delete(IDbConnection conn)
        {
            var delete = new DapperProductRepository(conn);

            ReadProducts.InventoryList(conn);

            Console.WriteLine();
            Console.WriteLine("What productID you would like to delete?");
            var prodID = int.Parse(Console.ReadLine());

            delete.DeleteProduct(prodID);

            Console.WriteLine();

            Console.WriteLine($"ProductID {prodID} was deleted");
            TimeStamp.Date();

            Message.MenuExit(conn);
        }
    }
}
