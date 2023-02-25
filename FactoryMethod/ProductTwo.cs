using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.FactoryMethod
{
    public class ProductTwo: Product, IProduct
    {
        private readonly int _uniqueIndex;

        public ProductTwo(string description, int uniqueIndex)
        {
            _productName = "Type Two";

            ProductDescription = description;
            _uniqueIndex = uniqueIndex;
        }

        public override string GetProductData()
        {
            return ProductDescription;
        }
    }
}
