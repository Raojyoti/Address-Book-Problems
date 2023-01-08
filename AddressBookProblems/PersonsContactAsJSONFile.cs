using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace AddressBookProblems
{
    public class PersonsContactAsJSONFile
    {
        public static string importfilePath = @"E:\AddressBookProblemsUpdate\Address-Book-Problems\AddressBookProblems\Import.csv";
        public static string exportfilePath = @"E:\AddressBookProblemsUpdate\Address-Book-Problems\AddressBookProblems\Export.json";
        public static void ImplementCSVtoJSON()
        {
            using (var reader = new StreamReader(importfilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<PersonalDetails>().ToList();
                Console.WriteLine("Read Data successfully from import.csv file and here data are");
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
                Console.WriteLine("Read data from csv file Write data to Json File");
                JsonSerializer serializer=new JsonSerializer();
                using ( StreamWriter sw = new StreamWriter(exportfilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }
            }
        }
    }
}
