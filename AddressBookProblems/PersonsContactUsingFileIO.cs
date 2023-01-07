using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBookProblems
{
    public class PersonsContactUsingFileIO
    {
        public void CheckPersonsContactsFileExists(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("file Exists");
            }
            else
            {
                Console.WriteLine("File not exists");
            }
        }
        public void ReaderPersonsContactsFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    while (sr.ReadLine() != null)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            else
            {
                Console.WriteLine("File not exists");
            }
        }
        public void WriterPersonsContactsFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamWriter sr = File.AppendText(filePath))
                {
                    string word = " New Address Book:=\r\n---------------------------\r\nFirstName      :-   Piyush\r\nLastName       :-   Rao\r\nAddress        :-   Fire Station Khurja\r\nCity           :-   Khurjar\nState          :-   Uttar Pradesh\r\nZipcode        :-   203130\r\nPhonenumber    :-   8905982520\r\nEmail Id       :-   piy129@gmail.com\r\n\r\n-----------------------------------------------------------------\r\n\r\nFirstName      :-   Ritu\r\nLastName       :-   Roy\r\nAddress        :-   New Tehsil\r\nCity           :-   Agra\r\nState          :-   Uttar Pradesh\r\nZipcode        :-   143131\r\nPhonenumber    :-   7925982520\r\nEmail Id       :-   ritu593@gmail.com\r\n\r\n-----------------------------------------------------------------";
                    Console.WriteLine(word);
                    sr.Close();
                    Console.WriteLine(File.ReadAllText(filePath));
                }
            }
            else
            {
                Console.WriteLine("File not exists");
            }
        }
    }
}
