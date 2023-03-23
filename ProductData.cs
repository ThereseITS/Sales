using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Sales
{
    class ProductData
    {
        string path;
        List<Product> products;
        public ProductData(string filePath)
        {
            path = filePath;
            products = new List<Product>();
        }
        public List <Product>  ReadProducts()
        {
           
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string input;
                    decimal price;
                    int stockLevel;



                    while ((input = sr.ReadLine()) != null)
                    {
                        Console.WriteLine("Reading:" + input);
                        string[] fields = input.Split(','); // split input line

                        if (fields.Length == 4)
                        {

                            if (decimal.TryParse(fields[2], out price) && int.TryParse(fields[3], out stockLevel))
                            {
                                Product p = new Product(fields[0], fields[1], price, stockLevel);
                                products.Add(p);

                            }
                            else
                            {

                                Console.WriteLine($"Error in data on line{products.Count} : {input}");
                            }
                        }

                        else
                        {
                            Console.WriteLine("error - wrong number of fields");
                        }

                    }

                }


            }
            catch (FileNotFoundException ex)
            {

                Console.WriteLine($"File: {ex.FileName}  Not found {ex.Message}  {path}");
            }

            return products;
        }
        public void WriteProducts(List<Product> products)
        {


            try
            {

                using (StreamWriter sw = File.CreateText(path))
                {
                    foreach (Product p in products)
                    {
                        sw.WriteLine(p.GetCSV());
                    }
                }

            }

            
            catch (IOException ex)
            {

                Console.WriteLine($"I/O error writing to: {path}");
            }
        }

    }
}
