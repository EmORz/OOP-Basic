using ExplicitInterfaces.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces.Model
{
    public class Citizen : IPerson, IResident
    {
        private string name;
        private int age;
        private string country;

        public Citizen(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; private set => name = value; }
        public int Age { get => age; private set => age = value; }
        public string Country { get => country; private set => country = value; }


        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }
        string IPerson.GetName()
        {
            return this.Name;
        }
    }
}
