using BestBuy_CRUD.EndApp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BestBuy_CRUD
{
    public static class ReadProducts
    {
        public static void InventoryList(IDbConnection conn)
        {
            var repo = new DapperProductRepository(conn);
            var products = repo.GetAllProducts();

            foreach (var item in products)
            {
                Console.WriteLine($"{item.ProductID} {item.Name}");
            }          
        }
    }
}
