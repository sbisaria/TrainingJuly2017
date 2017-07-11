using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Training2017.Basics.QueueImplementation;

namespace Tavisca.Training2017.Basics.StackUsingQueuesImpl
{
    public class CustomStack
    {
        Queue queue1;
        Queue queue2;
        public CustomStack(int maxSize)
        {
            queue1 = new Queue(maxSize);
            queue2 = new Queue(maxSize);
        }

        public bool IsEmpty()
        {
            return queue1.IsEmpty();
        }

        public bool IsFull()
        {
            return queue1.IsFull();
        }

        public void Push(int numericValue)
        {
            queue1.Enqueue(numericValue);
        }

        public int Pop()
        {
            if (queue1.numberOfElemtsInQueue == 1)
                return queue1.Dequeue();
            for (int index = 0; index < queue1.numberOfElemtsInQueue; index++)
            {
                int value = queue1.Dequeue();
                queue2.Enqueue(value);
            }
            int poppedNumber = queue1.Dequeue();
            while(queue2.numberOfElemtsInQueue>0)
            {
                int value2 = queue2.Dequeue();
                queue1.Enqueue(value2);
            }
            return poppedNumber;
        }
    }
}
