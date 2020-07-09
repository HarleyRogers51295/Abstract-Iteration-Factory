using CollectionsConsoleUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndIteration
{
    class ListDataAccess : DataAccess , IDataAccess //moved everything from DataAccess t here.
    {

        public override void GetProduct() //this method gets the values of the product this and prints it out.
        {
            Console.WriteLine($"You have {Data.products.Count} products in stock.");

            Console.WriteLine("They are: ");

            foreach (Product p in Data.products)
            {
                Console.Write($"{p.Name} : {p.Price}");
                Console.WriteLine();
            }
        }

        public override void CreateProduct()
        {
            Product p = new Product();

            Console.WriteLine("Accessing your Static Database");

            Console.WriteLine("PLease give me the name of your product.");

            p.Name = Console.ReadLine();

            Console.WriteLine("PLease give me the price of your product.");

            //do this rather than decimal.Parse();
            string userStringNumber = Console.ReadLine();   //TryParse, or use Convert with a Try Catch.  Dont use Parse anymore.
            //see deffinition by going into () na dpress ctrl, shift, tap - space.
            //TryParse is safer than Parse.
            decimal price; //have to have something to stroee the value in.
            while (!decimal.TryParse(userStringNumber, out price))
            {
                Console.WriteLine("Invalid Entry");
                userStringNumber = Console.ReadLine();
            }
            //bool isSuccsefful = decimal.TryParse(userStringNumber, out price); 
            p.Price = price;
            Console.WriteLine("Adding your code to the static database \n");

            Data.products.Add(p);

        }
    }
}
