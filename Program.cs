using System;
using System.IO;
using static System.Console;
using System.Collections.Generic;
namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        { 
            string path = @"..\products.txt";
            ProductData pr = new ProductData(path);
            List<Product> productList = pr.ReadProducts();

            foreach (Product p in productList)
            {
                WriteLine(p);
             
            }
            ReadLine();
        }

        
}
}
