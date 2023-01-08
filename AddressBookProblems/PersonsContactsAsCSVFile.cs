using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace AddressBookProblems
{
    public class PersonsContactsAsCSVFile
    {
        public static string importfilePath = @"E:\AddressBookProblemsUpdate\Address-Book-Problems\AddressBookProblems\Import.csv";
        public static string exportfilePath = @"E:\AddressBookProblemsUpdate\Address-Book-Problems\AddressBookProblems\Export.csv";
        public static void ImplementJSONToCSV()
        {
            using (var reader = new StreamReader(importfilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<PersonalDetails>().ToList();
                Console.WriteLine("Read Data from csvFile");
                foreach (PersonalDetails contact in records)
                {
                    Console.Write("\n" + contact.firstName);
                    Console.Write("\n" + contact.lastName);
                    Console.Write("\n" + contact.address);
                    Console.Write("\n" + contact.city);
                    Console.Write("\n" + contact.state);
                    Console.Write("\n" + contact.zipcode);
                    Console.Write("\n" + contact.phonenumber);                    
                    Console.Write("\n" + contact.email);
                    Console.Write("\n");
                }

                using (var writer = new StreamWriter(exportfilePath))
                using (var csvImport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvImport.WriteRecords(records);
                }
            }
        }
    }
}
