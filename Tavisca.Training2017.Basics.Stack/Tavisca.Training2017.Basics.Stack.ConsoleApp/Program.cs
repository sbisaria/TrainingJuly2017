using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.Basics.Stack.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of stack");
            int size = Convert.ToInt32(Console.ReadLine());
            if (size > 0)
            {
                StackImplementation.Stack stack = new StackImplementation.Stack(size);
                while (true)
                {
                    Console.WriteLine("Enter 0 to push, 1 to pop and 2 to display");
                    int choice;
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 0)
                    {
                        if (stack.IsFull() == true)
                        {
                            Console.WriteLine("Stack is full");
                        }
                        else
                        {
                            Console.Write("Enter the value you want to push: ");
                            try
                            {
                                stack.Push(Convert.ToInt32(Console.ReadLine()));
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine("Invalid input");
                            }
                        }
                    }
                    else if (choice == 1)
                    {
                        if (stack.IsEmpty() == true)
                        {
                            Console.WriteLine("Stack is empty");
                        }
                        else
                        {
                            int returnedValue = stack.Pop();
                            Console.WriteLine("Popped value is: {0}", returnedValue);
                        }
                    }
                    else if (choice == 2)
                    {
                        if (stack.IsEmpty() == true)
                        {
                            Console.WriteLine("Stack is empty");
                        }
                        else
                        {
                            stack.Display();
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
