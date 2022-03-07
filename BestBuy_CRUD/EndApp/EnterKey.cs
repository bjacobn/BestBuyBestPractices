using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BestBuy_CRUD.EndApp
{
    public static class EnterKey
    {
        public static void Menu(IDbConnection conn)
        {
            Console.Clear();
            MainMenu.UserInput(conn);
        }
    }
}
