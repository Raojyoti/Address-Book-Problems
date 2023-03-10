using System;
using System.Collections.Generic;

namespace AddressBookProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            string personsContact = @"E:\AddressBookProblemsUpdate\Address-Book-Problems\AddressBookProblems\PersonsContact.txt";
            PersonsContactUsingFileIO fileIO = new PersonsContactUsingFileIO();
            Console.WriteLine("Welcome to the Address Book");
            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("The commands are:\n 1.create\n 2.list\n 3.edit\n 4.delete\n 5.addMultiContacts\n 6.newUser\n 7.checkDuplicateName\n 8.searchPersonByCityOrState\n 9.ViewPersonByCityOrState\n 10.CountCityOrState\n 11.SortPersonsName\n 12.SortPersonByCityStateOrZip\n 13.checkPersonsContactsFileExists\n 14.readerPersonsContactsFile\n 15.writerPersonsContactsFile\n 16.implementJSONToCSV\n 17.personsContactAsJSONFile.ImplementCSVtoJSON\n 18.exit\n ");
                Console.WriteLine("Please enter a command: ");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "create":
                        CreateContacts.PersonInformations();
                        break;
                    case "list":
                        CreateContacts.ListPeople();
                        break;
                    case "edit":
                        CreateContacts.EditOfDetails();
                        break;
                    case "delete":
                        CreateContacts.DeletePerson();
                        break;
                    case "addMultiContacts":
                        CreateContacts.AddMultipleContacts();
                        break;
                    case "newUser":
                        CreateContacts create = new CreateContacts();
                        create.NewUser();
                        break;
                    case "checkDuplicateName":
                        CreateContacts.DuplicateCheckPersonByName();
                        break;
                    case "searchPersonByCityOrState":
                        CreateContacts.SearchPersonByCityOrState();
                        break;
                    case "viewPersonByCityOrState":
                        CreateContacts.ViewPersonByCityOrState();
                        break;
                    case "countCityOrState":
                        CreateContacts.CountCityOrState();
                        break;
                    case "sortPersonsName":
                        CreateContacts.SortPersonsName();
                        break;
                    case "sortPersonByCityStateOrZip":
                        CreateContacts.SortPersonByCityStateOrZip();
                        break;
                    case "checkPersonsContactsFileExists":
                        fileIO.CheckPersonsContactsFileExists(personsContact);
                        break;
                    case "readerPersonsContactsFile":
                        fileIO.ReaderPersonsContactsFile(personsContact);
                        break;
                    case "writerPersonsContactsFile":
                        fileIO.WriterPersonsContactsFile(personsContact);
                        break;
                    case "implementJSONToCSV":
                        PersonsContactsAsCSVFile.ImplementJSONToCSV();
                        break;
                    case "personsContactAsJSONFile.ImplementCSVtoJSON":
                        PersonsContactAsJSONFile.ImplementCSVtoJSON();
                        break;
                    default:
                        if (command != "exit")
                        {
                            CreateContacts.DisplayHelp();
                        }
                        break;
                }
            }
        }
    }
}
