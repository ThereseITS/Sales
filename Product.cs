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
            set
            {
                _productName = value;
            }
        }
     
        public decimal UnitPrice { get; set; }

        public Product()
        {
            _productCode = "P" + pCounter.ToString();
            pCounter++;
        }
        public Product(string name, decimal uPrice):this()
        {
           
            this._productName = name;
            UnitPrice = uPrice;
            this._stockLevel = 0;
        }
        public void AddStock(int qty)
        {
            _stockLevel += qty;
        }

        public override string ToString()
        {
            return string.Format( $"{_productCode} {_productName} {UnitPrice:C} {_stockLevel}");
        }

    }
    
}
