using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuy_CRUD
{
   public interface IProductRepository
    {
        //Abstract methods
        IEnumerable<Product> GetAllProducts();

        void CreateProduct(string name, double price, int categoryID);

        void UpdateProduct(int productID, string updatedName);

        void DeleteProduct(int productID);
    }
}
