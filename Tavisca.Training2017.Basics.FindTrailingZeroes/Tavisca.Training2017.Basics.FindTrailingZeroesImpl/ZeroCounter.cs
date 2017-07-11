namespace Tavisca.Training2017.Basics.FindTrailingZeroesImpl
{
    public class ZeroCounter
    { 
        public int Count(int value)
        {
            int count = 0;
            while (value % 10 == 0)
            {
                count++;
                value = value / 10;
            }
            return count;
        }
    }
}
