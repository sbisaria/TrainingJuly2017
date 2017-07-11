using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Training2017.Basics.QueueUsingStacksImpl;

namespace Tavisca.Training2017.Basics.QueueUsingStacks.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of queue");
            int size = Convert.ToInt32(Console.ReadLine());
            if (size > 0)
            {
                CustomQueue queue = new CustomQueue(size);
                int choice;
                while (true)
                {
                    Console.WriteLine("Enter 0 to enqueue and 1 to dequeue and 2 to display");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 0)
                    {
                        if (queue.IsFull())
                        {
                            Console.WriteLine("Queue is full");
                        }
                        else
                        {
                            Console.WriteLine("Enter a value");
                            try
                            {
                                queue.Enqueue(Convert.ToInt32(Console.ReadLine()));
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine("Invalid input");
                            }
                        }
                    }
                    else if (choice == 1)
                    {
                        if (queue.IsEmpty())
                        {
                            Console.WriteLine("Queue is empty");
                        }
                        else
                        {
                            int value = queue.Dequeue();
                            Console.WriteLine("Dequeued value is : {0}", value);
                        }
                    }
                    else if (choice == 2)
                    {
                        if (queue.IsEmpty())
                        {
                            Console.WriteLine("Queue is empty");
                        }
                        else
                        {
                            queue.Display();
                        }
                    }
                }
            }
            else
                Console.WriteLine("Invalid size");
            Console.ReadLine();
        }
    }
}
