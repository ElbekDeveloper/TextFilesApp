using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TextFilesDemo
{
    class Person
    {
        //properties
        public string  Name { get; set; }
        public string PhoneCode { get; set; }

        public string  PhoneNumber { get; set; }
        public string Address { get; set; }

        //constructor
        public Person(string Name, string PhoneCode, string PhoneNumber, string Address)
        {
            this.Name = Name;
            this.PhoneCode = PhoneCode;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
        }
    }
}
