using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.FactoryMethod
{
    public enum SpecialType
    {
        p3one, 
        p3two
    }

    public class ProductThree: Product, IProduct
    {
        private SpecialType _isSpecialType;

        public ProductThree(string description, SpecialType type)
        {
            _productName = "Type Three";
            ProductDescription = description;
            _isSpecialType = type;
        }

        public override string GetProductData()
        {
            return "Type 3 data: " + _productName;
        }
    }
}
