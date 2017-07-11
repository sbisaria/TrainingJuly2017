using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.Basics.QueueImplementation
{
    public class Queue
    {
        public int numberOfElemtsInQueue = 0;
        int maxNumberOfElements = 0;
        int[] numbers;
        int rear = -1;
        int front = 0;
        
        public Queue(int maxSize)
        {
            numbers = new int[maxSize];
            maxNumberOfElements = maxSize;
        }
        public bool IsFull()
        {
            return numberOfElemtsInQueue == maxNumberOfElements;
        }
        public bool IsEmpty()
        {
            return numberOfElemtsInQueue == 0;
        }
        public void Enqueue(int numericVulaue)
        {
            rear += 1;
            numbers[rear] = numericVulaue;
            numberOfElemtsInQueue++;
        }
        public int Dequeue()
        {
            int dequeuedValue = numbers[front];
            front += 1;
            numberOfElemtsInQueue--;
            IncreaseSizeBy1();
            return dequeuedValue;
        }

        public void Display()
        {
            if (IsEmpty() == true)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("Values in queue are: ");
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }

        private void IncreaseSizeBy1()
        {
            int[] tempArray = new int[numbers.Length + 1];
            Array.Copy(numbers, tempArray, numbers.Length);
            numbers = tempArray;
        }
    }
}
