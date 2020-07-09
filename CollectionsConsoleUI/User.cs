using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsConsoleUI
{
    public static class User //since there is only one of these, you can make it static.
    {
        public static string FirstName { get; set; }


        public static void PrintName()
        {
            Console.WriteLine(FirstName);
        }
    }
}
