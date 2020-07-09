using CollectionsConsoleUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndIteration
{
    class MySQLDataAccess : DataAccess, IDataAccess //makes it inherit from both
    {
        public override void CreateProduct()
        {
            Console.WriteLine("Accessing your MySQL Database");

            Product p = new Product();

            Console.WriteLine("PLease give me the name of your product.\n");

            p.Name = Console.ReadLine();

            Console.WriteLine("PLease give me the price of your product.\n");


            string userStringNumber = Console.ReadLine();
            decimal price;
            while (!decimal.TryParse(userStringNumber, out price))
            {
                Console.WriteLine("Invalid Entry");
                userStringNumber = Console.ReadLine();
            }
            p.Price = price;

            Console.WriteLine("Adding your code to the MySQL database \n");
            Data.products.Add(p);

        }

        public override void GetProduct() //must put the override in.
        {
            Console.WriteLine($"You have {Data.products.Count} products in stock.\n");

            Console.WriteLine("They are: \n");

            foreach (Product p in Data.products)
            {
                Console.Write($"{p.Name} \n {p.Price}");
                Console.WriteLine();
            }
        }
    }
}
