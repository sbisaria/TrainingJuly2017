using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Training2017.Basics.FindTrailingZeroesImpl;

namespace Tavisca.Training2017.Basics.FindTrailingZeroes.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int numericValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter base");
            int baseValue = Convert.ToInt32(Console.ReadLine());

            BaseConverter converter = new BaseConverter();
            int number = converter.ToNumber(numericValue, baseValue);
            Console.WriteLine("The base 10 equivalent: {0}", number);

            FactorialCalculator factorialCalculator = new FactorialCalculator();
            int factorial = factorialCalculator.Calculate(number);
            Console.WriteLine("The factorial value is: {0}", factorial);

            int factorialBaseValue = converter.ToBase(factorial, baseValue);
            Console.WriteLine("The factorial value in given base is: {0}", factorialBaseValue);

            ZeroCounter counter = new ZeroCounter();
            int zeroCount = counter.Count(factorialBaseValue);

            Console.WriteLine("The number of trailing zeros is: {0}", zeroCount);
            Console.ReadLine();
        }
    }
}
