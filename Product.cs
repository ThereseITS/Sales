namespace Sales
{
    class Product
    {
        static int pCounter = 0;

       string _productCode;
       string _productName;
       int _stockLevel;
        

        public string ProductCode
        {
            get
            {
                return _productCode;
            }
            private set
            {
                _productCode = value;
            }
        }
        public string ProductName
        {
            get
            {
                return _productName;
            }
            private set
            {
                _productName = value;
            }
        }
        public int StockLevel
        {
            get
            {
                return _stockLevel;
            }
           private set
            {
                _stockLevel = value;
            }
        }


        public decimal UnitPrice { get; set; }

        public Product()
        {
            _productCode = "P" + pCounter.ToString();
            pCounter++;
        }
        public Product(string name, decimal uPrice, int stockLevel)
        {
            _productCode = "P" + pCounter.ToString();
            pCounter++;
            this._productName = name;
            UnitPrice = uPrice;
            this._stockLevel = stockLevel;
        }
        public Product(string code, string name, decimal uPrice, int stockLevel)
        {
            _productCode = code;
           
            this._productName = name;
            UnitPrice = uPrice;
            this._stockLevel = stockLevel;
        }
        public void AddStock(int qty)
        {
            _stockLevel += qty;
        }

        /// <summary>
        ///  The stocklevel is updated.
        /// </summary>
        /// <param name="qty"></param>
        /// <returns>Returns the quantity of items bought stocklevel, if qty>stockLevel.</returns>
        public int Buy(int qty)
        {
            if (_stockLevel >= qty)
            {
                _stockLevel -= qty;
            }
            else
            {
                qty = _stockLevel;
                _stockLevel = 0;
            }
            return qty;
        }
        public string GetCSV()
        {
            return string.Format($"{_productCode},{_productName},{UnitPrice},{_stockLevel}");
        }
        public override string ToString()
        {
            return string.Format( $"{_productCode,10} {_productName,20} {UnitPrice:C} {_stockLevel,10}");
        }

    }
    
}
