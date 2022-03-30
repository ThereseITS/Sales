using System;
using System.Collections.Generic;
using System.Text;

namespace Sales
{
    class SalesItem
    {

        string _productName;
        int _quantity;
        decimal _price;

        public SalesItem(string name,int quantity, decimal price)
        {
         _productName = name;
        _quantity = quantity;
        _price = price;
        }

        public decimal GetCost()
        {
            return _price * _quantity;
        }
        public override string ToString()
        {
            return $"{_productName,20} {_price,10} {_quantity,10} {GetCost(),10}";
        }
    }
}
