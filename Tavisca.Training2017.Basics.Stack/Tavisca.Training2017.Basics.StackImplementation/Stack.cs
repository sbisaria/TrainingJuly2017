using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.Basics.StackImplementation
{
    public class Stack
    {
        int[] numbers;
        int top = -1;

        public Stack(int maxSize)
        {
            numbers = new int[maxSize];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == numbers.Length - 1;
        }
        public void Push(int numericValue)
        {
            ++top;
            numbers[top] = numericValue;
        }

        public int Pop()
        {
            int poppedValue = numbers[top--];
            return poppedValue;
        }
        public void Display()
        {
            Console.WriteLine("Values in stack are:");
            for (int index = top; index >= 0; index--)
            {
                Console.WriteLine(numbers[index]);
            }
        }
    }
}
