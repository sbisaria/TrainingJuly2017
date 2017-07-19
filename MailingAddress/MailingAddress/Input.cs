using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingAddress
{
    class Input
    {
        Address address;
        public Input()
        {
            address = new Address();
        }

        public void GetInput()
        {
            Console.WriteLine("Name: ");
            address.Name = Console.ReadLine();

            Console.WriteLine("City: ");
            address.City = Console.ReadLine();

            Console.WriteLine("Street: ");
            address.Street = Console.ReadLine(); 

            Console.WriteLine("House No: ");
            address.HouseNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Pin: ");
            address.Pin = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Full mailing address is: ");
            Console.WriteLine(address.GetAddress());

        }
    }
}
