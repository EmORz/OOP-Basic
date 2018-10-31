using ExplicitInterfaces.Contracts;
using ExplicitInterfaces.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces.Core
{
    public class Engine
    {
        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string name = input.Split()[0];
                IPerson person = new Citizen(name);
                IResident resident = new Citizen(name);
                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());

                input = Console.ReadLine();
            }
        }
    }
}
