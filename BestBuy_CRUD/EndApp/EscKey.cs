using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BestBuy_CRUD.EndApp
{
   public static  class EscKey
    {
        public static void Exit (IDbConnection conn)
        {
            Console.Clear();
            Console.WriteLine(" Exiting BestBuy CRUD.");
            Environment.Exit(0);
        }
    }
}
