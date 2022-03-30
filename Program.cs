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
           
            string path = @".\products.txt";
            ProductData pr = new ProductData(path);
            List<Product> productList = pr.ReadProducts();

            string[] menuOptions = { "Sales transaction", "Quit" };
            Menu m = new Menu(menuOptions);
            int choice = m.GetMenuChoice();

            while (choice != menuOptions.Length)
            {

                switch (choice)
                {
                    case 1: ProcessSale(productList);break;
                    
                    default:break;

                }
                choice = m.GetMenuChoice();
            }
           

        }
        static decimal ProcessSale(List<Product> productList)
        {
            decimal total = 0m;
            int count = 0;
            Basket b = new Basket();
            string another = "y";

            while (another.ToUpper()== "Y")
            {
                count = 0;
                foreach (Product p in productList)
                {
                    WriteLine($"{count}. {p.ToString()}");

                    count++;
                }
                WriteLine("Select a Product:");
                int index;
                while (!(int.TryParse(ReadLine(), out index) && (index >= 0) && (index < productList.Count)))
                {
                    WriteLine("Please enter a valid number");
                }

                WriteLine("Please enter quantity:");
                int qty;
                while (!(int.TryParse(ReadLine(), out qty) && (qty >= 0)))
                {
                    WriteLine("Please enter a valid quantity:");
                }
                int quantityBought = productList[index].Buy(qty);
                WriteLine($"You have just bought {quantityBought} of {productList[index].ProductName} @ {productList[index].UnitPrice}");
                b.AddItem(productList[index].ProductName, quantityBought, productList[index].UnitPrice);

                WriteLine("Another ?");
                another = ReadLine();
                
                
            }
            WriteLine(b.ToString());
       
            return total;
        }

        
}
}
