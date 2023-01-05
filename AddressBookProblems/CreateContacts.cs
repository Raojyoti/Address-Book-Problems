using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblems
{
    public class CreateContacts
    {
        public static List<PersonalDetails> Person = new List<PersonalDetails>();
        public static void PersonInformations()
        {
            PersonalDetails contacts = new PersonalDetails();
            Console.Write("Enter First Name:   ");
            contacts.firstName = Console.ReadLine();
            Console.Write("Enter Last Name:   ");
            contacts.lastName = Console.ReadLine();
            Console.Write("Enter Address:   ");
            contacts.address = Console.ReadLine();
            Console.Write("Enter City Name:   ");
            contacts.city = Console.ReadLine();
            Console.Write("Enter State Name:   ");
            contacts.state = Console.ReadLine();
            Console.Write("Enter ZipCode:   ");
            contacts.zipcode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Phone Number:   ");
            contacts.phonenumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Email Id:   ");
            contacts.email = Console.ReadLine();
            Person.Add(contacts);
        }
    }
}
