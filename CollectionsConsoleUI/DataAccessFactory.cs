using CollectionsConsoleUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndIteration
{
    //factory must be static
    static class DataAccessFactory  //This is the factory pattern
    {
        public static DataAccess GetDataAccess(string dataBaseType) //alows the user to choose their DataBase
        {
            switch (dataBaseType.ToLower())
            {
                case "list":
                case "regular":
                    //return new DataAccess; //Cannot create an instatnce of an abstract class.
                    return new ListDataAccess();
                case "mongodb":
                case "mongo":
                case "mon":
                    return new MongoDBDataAccess();
                case "my":
                case "sql":
                case "mysql":
                    return new MySQLDataAccess();
                default:
                    return new ListDataAccess();
                   

            }
        }

    }
}
