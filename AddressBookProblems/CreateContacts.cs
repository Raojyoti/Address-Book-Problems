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
        public static void PrintPerson(PersonalDetails contact)
        {
            Console.WriteLine("First Name: " + contact.firstName);
            Console.WriteLine("Last Name: " + contact.lastName);
            Console.WriteLine("City Name: " + contact.city);
            Console.WriteLine("Address : " + contact.address);
            Console.WriteLine("State : " + contact.state);
            Console.WriteLine("Zip Code : " + contact.zipcode);
            Console.WriteLine("Phone Number: " + contact.phonenumber);
            Console.WriteLine("Email Id : " + contact.email);
            Console.WriteLine("-------------------------------------------");
        }
        public static void ListPeople()
        {
            Console.Clear();
            if (Person.Count == 0)
            {
                Console.WriteLine("Your address book is empty.\n Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var contact in Person)
            {
                PrintPerson(contact);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
        public static void DisplayHelp()
        {
            Console.Clear();
            Console.WriteLine("Enter only Available Commands are :");
            Console.WriteLine("add => \tAdds a person to address book");
            Console.WriteLine("edit => \tEdit a person to address book by first name");
            Console.WriteLine("remove => \tRemoves a person from address book");
            Console.WriteLine("list => \tLists out all people in the address book");
            Console.WriteLine("Press \tAny key to continue");
            Console.WriteLine("\n");
        }
    }
}
