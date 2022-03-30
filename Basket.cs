using System;
using System.Collections.Generic;
using System.Text;

namespace Sales
{
    class Basket
    {
        List<SalesItem> _items ;
   
        public Basket()
        {
           
            _items = new List<SalesItem>();
        }
      

        public void AddItem(string name, int quantity, decimal price)
        {
           
            _items.Add(new SalesItem(name, quantity,price));
            
        }
        public decimal CalculateTotalCost ()
        {
            decimal totalCost=0m;

            foreach (SalesItem i in _items)
            {
                totalCost += i.GetCost();
            }

            return totalCost;
        }
        public override string ToString()
        {
            string s="";
            foreach (SalesItem i in _items)
            {
                s = s + i.ToString() + "\n";
            }
            s = s + "Total cost: " + this.CalculateTotalCost().ToString();
            return s;
        }
    }
}
