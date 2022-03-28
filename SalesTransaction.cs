using System;
using System.Collections.Generic;
using System.Text;

namespace Sales
{
    class SalesTransaction
    {
        SalesItem[] items;
        static int maxItems=10;
        
        int nItems = 0;

        public SalesTransaction(int max)
        {
            maxItems = max;
            items = new SalesItem[maxItems];
        }
        public SalesTransaction()
        {
            
            items = new SalesItem[maxItems];
        }

        public bool AddItem(Product p, int qty)
        {
            if (nItems < maxItems)
            {
                items[nItems] = new SalesItem(p, qty);
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
