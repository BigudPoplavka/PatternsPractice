using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPractice.FactoryMethod
{
    public class FactoryMethodExample : IPatternExample
    {
        public int typeAnswer;

        public ProductFactory GetProductFactory(int type) => type switch
        {
            1 => new TypeOneFactory(200, "Type one description"),
            2 => new TypeTwoFactory("Type two description", 012),
            3 => new TypeThreeFactory("Type three description - special type one", SpecialType.p3one),
            4 => new TypeThreeFactory("Type three description - special type two", SpecialType.p3two)
        };

        public void StartExample()
        {

            Console.WriteLine("Enter the object type: \n 1 - Type one \n 2 - Type two " +
                "\n 3 - Type three\\subtype one \n 4 - Type thee\\subtype two \n 0 - Exit\n");

            try
            {
                int.TryParse(Console.ReadLine(), out typeAnswer);

                ProductFactory productFactory = GetProductFactory(typeAnswer);

                IProduct product = productFactory.GetProduct();

                Console.WriteLine($"\nProduct type: {product.GetType()}\n");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Error!!!");
                Console.ReadKey();
            }
        }
    }
}
