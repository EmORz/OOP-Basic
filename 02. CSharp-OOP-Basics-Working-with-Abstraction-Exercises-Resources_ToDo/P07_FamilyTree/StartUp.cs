using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_FamilyTree
{
    class StartUp
    {
        public static List<Person> familyTree;
        static void Main(string[] args)
        {
            familyTree = new List<Person>();
            List<string> relations = new List<string>();
            string personInput = Console.ReadLine();           

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                if (command.Contains("-"))
                {
                    relations.Add(command);
                    continue;
                }
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0] + " " + tokens[1];
                var birthday = tokens[2];
                familyTree.Add(new Person(name, birthday));
            }
            foreach (var line in relations)
            {
                var tokens = line.Split("-", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                var parentsParam = tokens[0];
                var childrenParam = tokens[1];

                var parent = GetParent(parentsParam);
                var children = GetParent(childrenParam);
                parent.AddChild(children);
                children.AddParent(parent);
            }

            var person = GetParent(personInput);
            person.Print();
        }

        private static Person GetParent(string paramss)
        {
            return paramss.Contains("/")
                                ? familyTree.First(x => x.GetBirthDay().Equals(paramss))
                                : familyTree.First(x => x.GetName().Equals(paramss));
        }        
    }
}
