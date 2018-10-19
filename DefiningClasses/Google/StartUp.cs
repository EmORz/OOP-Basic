using System;
using System.Collections.Generic;
using System.Linq;

namespace Google
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string commands = Console.ReadLine();
            List<People> persons = new List<People>();


            while (commands != "End")
            {
                string[] tokens = commands.Split();
                string personName = tokens[0];

                if (!persons.Any(x => x.Name == personName))
                {
                    persons.Add(new People(personName));
                }

                string actions = tokens[1];
                People person = persons.Where(x => x.Name == personName).First();

                switch (actions)
                {
                    case "company":
                        string name = tokens[2];
                        string department = tokens[3];
                        decimal salary = decimal.Parse(tokens[4]);
                        person.company = new Company(name, department, salary);
                        break;
                    case "pokemon":
                        string pokemonName = tokens[2];
                        string type = tokens[3];
                        person.pokemon.Add(new Pokemon(pokemonName, type));
                        break;
                    case "parents":
                        string parentsName = tokens[2];
                        string parentsBirthday = tokens[3];
                        person.parents.Add(new Parents(parentsName, parentsBirthday));

                        break;
                    case "children":
                        string childName = tokens[2];
                        string chiledBirthday = tokens[3];
                        person.children.Add(new Children(childName, chiledBirthday));
                        break;
                    case "car":
                        string model = tokens[2];
                        int speed = int.Parse(tokens[3]);
                        person.car = new Car(model, speed);
                        break;    
                }

                commands = Console.ReadLine();
            }

            string anotherCommand = Console.ReadLine();

            People pers = persons.Where(x => x.Name == anotherCommand).First();

            Console.WriteLine(pers.Name);
            Console.WriteLine("Company:");
            if (pers.company !=null)
            {
                Console.WriteLine(pers.company);
            }
            Console.WriteLine("Car:");
            if (pers.car != null)
            {
                Console.WriteLine(pers.car);
            }
            Console.WriteLine("Pokemon:");
            pers.pokemon.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Parents:");
            pers.parents.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Children:");
            pers.children.ForEach(x => Console.WriteLine(x));
        }
    }
}
