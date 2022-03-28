using System;
using System.Collections.Generic;
using System.Text;

namespace Sales
{
    class SalesItem
    {

        public Product p;
        int quantity;

        public SalesItem(Product p, int q)
        {
            this.p = p;
            quantity = q;
        }

        public decimal GetCost()
        {
            return p.UnitPrice * quantity;
        }
        public override string ToString()
        {
            return $"{p.ProductName,15} {quantity,10} {this.GetCost()}";
        }
    }
}
