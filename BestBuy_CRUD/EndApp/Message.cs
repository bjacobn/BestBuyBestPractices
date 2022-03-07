using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BestBuy_CRUD.EndApp
{
    public static class Message
    {
        public static void MenuExit(IDbConnection conn)
        {
            Console.WriteLine();
            Console.WriteLine("Press (Enter) for the Main Menu or (ESC) to Exit...");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                EnterKey.Menu(conn);
            }

            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                EscKey.Exit(conn);
            }
        } 
    }
}
