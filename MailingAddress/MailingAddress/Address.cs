using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingAddress
{
    class Address
    {
        private string name;
        private string city;
        private string street;
        private int pin;
        private int houseNo;

        public string Name
        {
            get{ return name;}
            set{ name = value;}
        }

        public int Pin
        {
            get{ return pin;}
            set{ pin = value;}
        }

        public int HouseNo
        {
            get{ return houseNo;}
            set{ houseNo = value;}
        }

        public string Street
        {
            get { return street;}
            set { street = value;}
        }

        public string City
        {
            get{ return city;}
            set{ city = value;}
        }

        public string GetAddress()
        {
            string completeAddress = "\n" + Name + " \n" + HouseNo + " \n" + Street + " \n" + City + "\n" + Pin;
            return completeAddress;
        }
    }
}
