using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.FactoryMethod
{
    public class ProductOne : Product, IProduct
    {
        public ProductOne(string description, int minPrice)
        {
            _productName = "Type One";
            
            ProductDescription = description;
            MinPrice = minPrice;
        }

        public override string GetProductData()
        {
            return "T1: " + _productName;
        }
    }
}
