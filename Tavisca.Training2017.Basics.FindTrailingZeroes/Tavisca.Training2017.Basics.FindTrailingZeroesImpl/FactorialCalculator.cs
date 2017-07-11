using System.Collections.Generic;
using System.Text;

namespace Tavisca.Training2017.Basics.FindTrailingZeroesImpl
{
    public class FactorialCalculator
    {
        public int Calculate(int number)
        {
            int factorial = 1;

            for (int index = 1; index <= number; index++)
            {
                factorial = factorial * index;
            }
            return factorial;
        }
    }
}
