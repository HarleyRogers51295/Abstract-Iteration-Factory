using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndIteration
{
    static class Data //this can take the Product List due to both not being public. They are internal.
    {

        public static List<Product> products = new List<Product>()
        {
           new Product() { Name="Keyboard", Price = 120.99m},
           new Product() { Name="Monitor", Price = 220.99m},
           new Product() { Name="Mouse", Price = 20.99m},
           new Product() { Name="Computer", Price = 1200.99m},
           new Product() { Name="Mouse Pad", Price = 10.99m},
        };   //You dont do this in real code.
    }
}
