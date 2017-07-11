using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Training2017.Basics.StackImplementation;

namespace Tavisca.Training2017.Basics.QueueUsingStacksImpl
{
    public class CustomQueue
    {
        Stack primaryStack;
        Stack secondaryStack;

        public CustomQueue(int maxSize)
        {
            primaryStack = new Stack(maxSize);
            secondaryStack = new Stack(maxSize);
        }
        public bool IsFull()
        {
            return primaryStack.IsFull();
        }
        public bool IsEmpty()
        {
            return primaryStack.IsEmpty();
        }

        public void Enqueue(int numericValue)
        {
            primaryStack.Push(numericValue);
        }

        public int Dequeue()
        {
            
            while (primaryStack.IsEmpty() == false)
            {
                int value = primaryStack.Pop();
                secondaryStack.Push(value);
            }
            int poppedValue = secondaryStack.Pop();
            while (secondaryStack.IsEmpty() == false)
            {
                int value = secondaryStack.Pop();
                primaryStack.Push(value);
            }
            return poppedValue;
        }

        public void Display()
        {
            while (primaryStack.IsEmpty() == false)
            {
                int value = primaryStack.Pop();
                secondaryStack.Push(value);
            }
            secondaryStack.Display();
            while (secondaryStack.IsEmpty() == false)
            {
                int value = secondaryStack.Pop();
                primaryStack.Push(value);
            }
        }
    }
}
