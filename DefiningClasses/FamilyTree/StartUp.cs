using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyTree
{
    public class StartUp
    {
        static List<Person> allPerson;
        static List<string> relationships;

        static void Main(string[] args)
        {
            allPerson = new List<Person>();
            relationships = new List<string>();

            string searchedPerson = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (!input.Contains("-"))
                {
                    AddMember(input);
                }
                else
                {
                    relationships.Add(input);
                }

                input = Console.ReadLine();

            }
            foreach (var membersInfo in relationships)
            {
                var tokens = membersInfo.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                Person parent = GetPerson(tokens[0]);
                Person child = GetPerson(tokens[1]);
                
                    parent.child.Add(child);
                
                    child.parents.Add(parent);
                

            }
            Print(searchedPerson);
        }

        private static void Print(string searchedPerson)
        {
            Person mainPerson = GetPerson(searchedPerson);

            Console.WriteLine($"{mainPerson.Name} {mainPerson.BirthDay}");
            Console.WriteLine("Parents:");
            if (mainPerson.parents!=null)
            {
                foreach (var parents in mainPerson.parents)
                {
                    Console.WriteLine($"{parents.Name} {parents.BirthDay}");
                }
            }
            Console.WriteLine("Children:");

            if (mainPerson.child !=null)
            {
                foreach (var child in mainPerson.child)
                {
                    Console.WriteLine($"{child.Name} {child.BirthDay}");
                }

            }

        }

        private static Person GetPerson(string input)
        {
            if (input.Contains("/"))
            {
                return allPerson.FirstOrDefault(x => x.BirthDay == input);
            }
            return allPerson.FirstOrDefault(x => x.Name == input);
        }

        private static void AddMember(string input)
        {
            string[] tokens = input.Split();
            string name = tokens[0]+" "+tokens[1];
            string date = tokens[2];
            allPerson.Add(new Person(name, date));
        }
    }
}
