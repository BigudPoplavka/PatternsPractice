using System;

namespace PatternsPractice.FactoryMethod
{
	public abstract class Product: IProduct
{
		protected string _productDescription;
		protected string _productName;
        private int _minPrice;
        public string ProductDescription { get => _productDescription; set => _productDescription = value; }
		public string ProductName { get => _productName; }
        protected int MinPrice { get => _minPrice; set => _minPrice = value; }

        public Product() { }

        public virtual string GetProductData()
        {
			return ProductDescription;
        }
    }
}
