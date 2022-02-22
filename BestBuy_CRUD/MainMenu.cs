using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuy_CRUD
{
    public static class MainMenu
    {
        public static void Menu()
        {
            Console.WriteLine("Please choose a number from the options below:");
            Console.WriteLine("1.) View all products");
            Console.WriteLine("2.) Create new product");
            Console.WriteLine("3.) Update exsiting product");
            Console.WriteLine("4.) Delete product ");
            Console.WriteLine("5.) Exit\n");
        }
    }
}
