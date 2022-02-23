using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuy_CRUD
{
    public static class TimeStamp
    {
        public static void Date()
        {
            Console.WriteLine();
            DateTime now = DateTime.Now;
            Console.WriteLine("NOW: " + now);
        }
    }
}
