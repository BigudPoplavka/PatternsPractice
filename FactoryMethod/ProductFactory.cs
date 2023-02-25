using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.FactoryMethod
{
    public abstract class ProductFactory
    {
        private string name;
        private string description;

        protected string Name { get => name; set => name = value; }
        protected string Description { get => description; set => description = value; }

        public abstract IProduct GetProduct();
    }
}
