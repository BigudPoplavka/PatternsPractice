using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.FactoryMethod
{
    public class TypeThreeFactory : ProductFactory
    {
        private SpecialType _isSpecialType;

        public TypeThreeFactory(string description, SpecialType isSpecialType)
        {
            Description = description;
            _isSpecialType = isSpecialType;
        }

        public override IProduct GetProduct()
        {
            return new ProductThree(Description, _isSpecialType);
        }
    }
}
