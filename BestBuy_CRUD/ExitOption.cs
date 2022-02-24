using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BestBuy_CRUD
{
    public static class ExitOption
    {
        public static void MenuOrExitKey(IDbConnection conn)
        {
            Console.WriteLine();
            Console.WriteLine("Press (Enter) for the Main Menu or (ESC) to Exit...");
            
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                MainMenu.Menu(conn);
            }

            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine(" Exiting BestBuy CRUD.");
                Environment.Exit(0);
            }
        }
    }
}

