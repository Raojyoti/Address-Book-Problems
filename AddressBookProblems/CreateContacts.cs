using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookProblems
{
    public class CreateContacts
    {
        public static List<PersonalDetails> Person = new List<PersonalDetails>();
        public static Dictionary<string, List<PersonalDetails>> book = new Dictionary<string, List<PersonalDetails>>();
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
        public static void EditOfDetails()
        {
            Console.WriteLine("Enter First Name: ");
            string name = Console.ReadLine();
            foreach (var data in Person)
            {
                if (Person.Contains(data))
                {
                    if (data.firstName == name)
                    {
                        Console.WriteLine("To edit contacts enter \n1.FirstName\n 2.LastName\n 3.Address\n 4.City\n 5.State\n 6.Zipcode\n 7.PhoneNumber\n");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Enter New First Name : ");
                                string firstName = Console.ReadLine();
                                data.firstName = firstName;
                                break;
                            case 2:
                                Console.WriteLine("Enter New Last Name : ");
                                string lastName = Console.ReadLine();
                                data.lastName = lastName;
                                break;
                            case 3:
                                Console.WriteLine("Enter New Address : ");
                                string address = Console.ReadLine();
                                data.address = address;
                                break;
                            case 4:
                                Console.WriteLine("Enter City : ");
                                string city = Console.ReadLine();
                                data.city = city;
                                break;
                            case 5:
                                Console.WriteLine("Enter New State : ");
                                string state = Console.ReadLine();
                                data.state = state;
                                break;
                            case 6:
                                Console.WriteLine("Enter New Zip Code : ");
                                int zipCode = Convert.ToInt32(Console.ReadLine());
                                data.zipcode = zipCode;
                                break;
                            case 7:
                                Console.WriteLine("Enter New Phone Number : ");
                                int phonenumber = Convert.ToInt32(Console.ReadLine());
                                data.phonenumber = phonenumber;
                                break;
                            default:
                                Console.WriteLine("Select Valid option ");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Name does not match");
                    }
                }
            }
        }
        public void DisplayList()
        {
            foreach (var pair in book.Keys)
            {
                Console.WriteLine("Address Book Name " + pair);
                foreach (PersonalDetails data in book[pair])
                {
                    Console.WriteLine("First Name: " + data.firstName);
                    Console.WriteLine("Last Name: " + data.lastName);
                    Console.WriteLine("Address: " + data.address);
                    Console.WriteLine("City : " + data.city);
                    Console.WriteLine("State: " + data.state);
                    Console.WriteLine("Zip : " + data.zipcode);
                    Console.WriteLine("Phone Number: " + data.phonenumber);
                    Console.WriteLine("EmailID: " + data.email);
                }
            }
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
        public static void DeletePerson()
        {
            List<PersonalDetails> Person = FindPeopleByFirstName();

            Console.Clear();

            if (Person.Count == 0)
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }

            if (Person.Count == 1)
            {
                DeletePersonFromList(Person.Single());
                Person.Single();
                return;
            }

            Console.WriteLine("Enter the number of the person you want to remove");
            for (int i = 0; i < Person.Count; i++)
            {
                Console.WriteLine(i);
                PrintPerson(Person.ElementAt(i));
            }
            int removePersonNumber = Convert.ToInt32(Console.ReadLine());
            if (removePersonNumber > Person.Count - 1 || removePersonNumber < 0)
            {
                Console.WriteLine("That number is invalid. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            DeletePersonFromList(Person.ElementAt(removePersonNumber));
        }
        public static void DeletePersonFromList(PersonalDetails contact)
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
            PrintPerson(contact);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Person.Remove(contact);
                Console.Clear();
                Console.WriteLine("Person removed. Press any key to continue.");
                Console.ReadKey();
            }
        }
        public static List<PersonalDetails> FindPeopleByFirstName()
        {
            Console.Clear();
            Console.WriteLine("Enter the first name of the person ");
            string firstName = Console.ReadLine();
            return Person.Where(x => x.firstName.ToLower() == firstName.ToLower()).ToList();
        }
        public static void AddMultipleContacts()
        {
            Console.WriteLine("Enter the Number of Records you want to Insert");
            int number = (int)Convert.ToInt64(Console.ReadLine());
            while (number > 0)
            {
                PersonInformations();
                number--;
            }
        }
        public void NewUser()
        {
            Console.WriteLine("Enter the Bookname: ");
            string Bookname = Console.ReadLine();
            Console.WriteLine("Enter The Number of Contacts To Add");
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                number--;
                PersonInformations();
                DisplayList();
            }
            book.Add(Bookname, Person.ToList());
        }
        public static void DuplicateCheckPersonByName()
        {
            List<PersonalDetails> Person = FindPeopleByFirstName();
            if (Person.Count == 0)
            {
                Console.WriteLine("That person could not be Present in Address Book");
                PersonInformations();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                return;
            }
            if (Person.Count == 1)
            {
                Console.WriteLine("That person Present in Address Book");
                ListPeople();
                return;
            }
        }
        public static List<PersonalDetails> PeopleByCityOrState()
        {
             Console.Clear();
            Console.WriteLine("Enter that City or State name where want to search the person name ");
            string CityOrState = Console.ReadLine();
            return Person.Where(x => x.city.ToLower() == CityOrState.ToLower() || x.state.ToLower() == CityOrState.ToLower()).ToList();
        }
        public static void SearchPersonByCityOrState()
        {
            List<PersonalDetails> Person = PeopleByCityOrState();
            if (Person.Count == 0)
            {
                Console.WriteLine("That city or state could not be Present in Address Book");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                return;
            }
            if (Person.Count == 1)
            {
                Console.WriteLine("That Details Present in Address Book");
                ListPeople();
                return;
            }
        }
        public static void ViewPersonByCityOrState()
        {
            Console.Clear();
            Console.Write("Enter that City or State name you want to view the person name: ");
            string CityOrState = Console.ReadLine();
            foreach (var data in Person)
            {
                if (Person.Contains(data))
                {
                    if (data.city == CityOrState)
                    {
                        var values = Person.Where(x => x.city.ToLower() == CityOrState.ToLower()).ToList();
                        foreach (var result in values)
                        {
                            Console.WriteLine(result.firstName + "  " + result.lastName + "  " + result.city);
                        }
                    }
                    else
                    {
                        if (data.state == CityOrState)
                        {
                            var values = Person.Where(x => x.state.ToLower() == CityOrState.ToLower()).ToList();
                            foreach (var results in values)
                            {
                                Console.WriteLine(results.firstName + "  " + results.lastName + "  " + results.state);
                            }
                        }
                    }
                }
            }
        }
        public static void CountCityOrState()
        {
            Console.Clear();
            Console.WriteLine("Enter the City or State name that want to count ");
            string CityOrState = Console.ReadLine();
            Console.WriteLine("Number of contact person that is count by City or State");
            Console.WriteLine("----------------------------------------------------------");
            foreach (var data in Person)
            {
                if (Person.Contains(data))
                {
                    if (data.city == CityOrState)
                    {
                        var values = Person.Count(x => x.city.ToLower() == CityOrState.ToLower());
                        Console.WriteLine(values);
                    }
                    else
                    {
                        if (data.state == CityOrState)
                        {
                            var values = Person.Count(x => x.state.ToLower() == CityOrState.ToLower());
                            Console.WriteLine(values);
                        }
                    }
                }
            }
        }
        public static void SortPersonsName()
        {
            var values = Person.OrderBy(x => x.firstName.ToLower()).ToList();
            Console.WriteLine("Sort person name in alphabetically");
            Console.WriteLine("-------------------------------------");
            foreach (var result in values)
            {
                Console.WriteLine(result.firstName);
            }
        }
        public static void SortPersonByCityStateOrZip()
        {
            var citysort = Person.OrderBy(x => x.city.ToLower()).ToList();
            var statesort = Person.OrderBy(x => x.state.ToLower()).ToList();
            var zipcodesort = Person.OrderBy(x => x.zipcode).ToList();
            Console.WriteLine("Sort person name city name");
            Console.WriteLine("--------------------------------------");
            foreach (var result in citysort)
            {
                Console.WriteLine(result.firstName + "    " + result.city);
            }
            Console.WriteLine("Sort person name by state name");
            Console.WriteLine("-----------------------------------");
            foreach (var result in statesort)
            {
                Console.WriteLine(result.firstName + "    " + result.state);
            }
            Console.WriteLine("Sort person name by zipcoad");
            Console.WriteLine("----------------------------------");
            foreach (var result in zipcodesort)
            {
                Console.WriteLine(result.firstName + "     " + result.zipcode);
            }
        }
    }
}
