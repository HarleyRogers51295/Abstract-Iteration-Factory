using AbstractAndIteration;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CollectionsConsoleUI
{
    class Program
    {
    static void Main(string[] args)
        {

            //THIS IS NOT ACTUALLY ACCESSING A DATBASE. THIS IS AN EXAMPLE.

            //IDataAccess da = new ListDataAccess();
            //IDataAccess da = new MongoDBDataAccess(); //You can switch this easily just by changin the name to the other. It switches databases.
            //IDataAccess da = new MySQLDataAccess();

            Console.WriteLine("Choose your data base");
            Console.WriteLine("PLease enter Regular or list for a static list");
            Console.WriteLine("PLease enter MySQL for a MySQL");
            Console.WriteLine("PLease enter Mongo for a Mongo DB");

            string dbType = Console.ReadLine();

            DataAccess da = DataAccessFactory.GetDataAccess(dbType); //this calls the facotry class.
           
            da.CreateProduct();

            da.GetProduct();

            da.ConnectionString = "Random string";



        }
        
    }
}
