﻿using System;
using System.Collections.Generic;

namespace AddressBookProblems
{
    public class Program
    {
        public static List<PersonalDetails> Person = new List<PersonalDetails>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book");
            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("The commands are:\n 1.create\n 2.list\n 3.edit\n 4.delete\n 5.addMultiContacts\n 5.exit\n ");
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
