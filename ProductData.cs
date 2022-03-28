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
            FileStream fs;
            try
            {
                fs = new FileStream(path, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                string input;
                decimal price;
                
                

                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine("Reading:" + input);
                    string[] fields = input.Split(','); // split input line

                    if (fields.Length == 2)
                    {

                        if (decimal.TryParse(fields[1], out price))
                        {
                            Product p = new Product(fields[0], price);
                            products.Add(p);
                            
                        }
                        else
                        {

                            Console.WriteLine($"error in data on line{products.Count} : {input}");
                        }
                    }
                   
                    else
                    {
                        Console.WriteLine("error - wrong number of fields");
                    }

                }

                sr.Close();


            }
            catch (FileNotFoundException ex)
            {

                Console.WriteLine($"File: {ex.FileName}  Not found {ex.Message}  {path}");
            }



            return products;
        }

    }
}
