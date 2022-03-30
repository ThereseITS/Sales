using System;
using System.Collections.Generic;
using System.Text;

namespace Sales
{
    class Basket
    {
        SalesItem[] items;
        static int maxItems=10;
        
        int nItems = 0;

        public Basket(int max)
        {
            maxItems = max;
            items = new SalesItem[maxItems];
        }
        public Basket()
        {
            
            items = new SalesItem[maxItems];
        }

        public bool AddItem(string name, int quantity, decimal price)
        {
            if (nItems < maxItems)
            {
                items[nItems] = new SalesItem(name, quantity,price);
                nItems++;
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public decimal CalculateTotalCost ()
        {
            decimal totalCost=0m;

            for (int i=0;i<nItems;i++)
            {
                totalCost += items[i].GetCost();
            }

            return totalCost;
        }
        public override string ToString()
        {
            string s="";
            for (int i = 0; i < nItems; i++)
            {
                s = s + items[i].ToString() + "\n";
            }
            s = s + "total cost: " + this.CalculateTotalCost().ToString();
            return s;
        }
    }
}
