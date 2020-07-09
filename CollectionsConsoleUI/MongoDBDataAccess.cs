using CollectionsConsoleUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AbstractAndIteration
{
    class MongoDBDataAccess : DataAccess , IDataAccess
    {
        public override void CreateProduct()
        {
            Console.WriteLine("Accessing your Mongo Database");

            Product p = new Product();

            Console.WriteLine("PLease give me the name of your product.");

            p.Name = Console.ReadLine();

            Console.WriteLine("PLease give me the price of your product.");

            
            string userStringNumber = Console.ReadLine();   
            decimal price; 
            while (!decimal.TryParse(userStringNumber, out price))
            {
                Console.WriteLine("Invalid Entry");
                userStringNumber = Console.ReadLine();
            }
            p.Price = price;

            Console.WriteLine("Adding your code to the Mongo database");
            Data.products.Add(p);

        }

        public override void GetProduct()
        {
            Console.WriteLine($"You have {Data.products.Count} products in stock.");

            Console.WriteLine("They are: ");

            foreach (Product p in Data.products)
            {
                Console.Write($"{p.Name} : {p.Price}");
                Console.WriteLine();
            }
        }
    }
}
