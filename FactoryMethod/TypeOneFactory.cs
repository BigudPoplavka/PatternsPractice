using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.FactoryMethod
{
    public class TypeOneFactory : ProductFactory
    {
        private int _minPrice;

        public TypeOneFactory(int mimPrice, string description)
        {
            _minPrice = mimPrice;
            Description = description;
        }

        public override IProduct GetProduct()
        {
            return new ProductOne(Description, _minPrice);
        }
    }
}
