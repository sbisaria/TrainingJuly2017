using System;

namespace Tavisca.Training2017.Basics.FindTrailingZeroesImpl
{
    public class BaseConverter {
        public int ToNumber(int number, int baseValue)
        {
            int convertedValue = 0;
            int index = 0;
            while (number > 0)
            {
                int modValue = number % 10;
                int powerValue = (int)Math.Pow(baseValue, index);
                convertedValue += powerValue * modValue;
                number = number / 10;
                index++;
            }
            return convertedValue;
        }

        public int ToBase(int number, int baseValue)
        {
            String text = "";
            while (number > 0)
            {
                int tempValue = number % baseValue;
                text = tempValue.ToString() + text;

                number = number / baseValue;
            }

            int convertedFactorialValue = int.Parse(text);
            return convertedFactorialValue;
        }
    }
}
