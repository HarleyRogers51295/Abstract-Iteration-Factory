using AbstractAndIteration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsConsoleUI
{
    public abstract class DataAccess  //this being abstract makes the below a default implimitation
    {
        public string ConnectionString { get; set; }

        public abstract void GetProduct(); //thwese make it so the other classes must have these methods to be a DataAcecess class.
       

        public abstract void CreateProduct();
       
    }
}
