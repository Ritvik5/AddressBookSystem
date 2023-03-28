using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Contacts
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int Zip;
        public int PhoneNumber;
        public string Email;
        public Contacts(string firstName, string lastName, string addr, string city,string state, int zip, int phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = addr;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
