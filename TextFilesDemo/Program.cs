using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TextFilesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"..\..\TextFile.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            List<Person> people = new List<Person>();

            foreach (var line in lines)
            {
                string[] entries = line.Split(' ');
                Person newPerson = new Person(entries[0], entries[1], entries[2], entries[3]);

                //add to the list of people
                people.Add(newPerson);
            }

            foreach (var person in people)
            {
                Console.WriteLine($"{ person.Name } lives in {person.Address}. You can contact him by calling  {person.PhoneCode} {person.PhoneNumber} ");
            }

            Console.ReadKey();

        }
    }
}
