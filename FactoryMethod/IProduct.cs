using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.FactoryMethod
{
    public interface IProduct
    {
        public string ProductDescription { get; }

        public string GetProductData();
    }
}
