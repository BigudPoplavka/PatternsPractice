using System;
using PatternsPractice.FactoryMethod;
using PatternsPractice.Buidler;
using PatternsPractice.Strategy;

namespace PatternsPractice
{
    class Program
    {
        public static IPatternExample patternExample;

        public static int answer;

        public static IPatternExample GetPatternExample(int answer) => answer switch
        {
            1 => new BuilderExample(),
            2 => new FactoryMethodExample(),
            3 => new StrategyExample()
        };

        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("\n\nВыбор паттерна: \nПОРОЖДАЮЩИЕ:\n |- 1 - Строитель" +
                    "\n |- 2 - Фабричный метод" +
                    "\nПОВЕДЕНЧЕСКИЕ:\n |- 3 - Стратегия \n--------\n0 - Выход");

                if (int.TryParse(Console.ReadLine(), out answer))
                {
                    if (answer == 0)
                        break;

                    patternExample = GetPatternExample(answer);
                    patternExample.StartExample();
                }
                else
                {
                    Console.WriteLine("ОШИБКА! Введите корректный вариант!");
                }
            }
        }
    }   
}
