using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.FactoryMethod
{
    public class TypeTwoFactory : ProductFactory
    {
        private int _uniqueIndex;
        public TypeTwoFactory(string description, int index)
        {
            Description = description;
            _uniqueIndex = index;
        }

        public override IProduct GetProduct()
        {
            return new ProductTwo(Description, _uniqueIndex);
        }
    }
}
