using BirthdayCelebrations.Contracts;
using System;

namespace BirthdayCelebrations.Models
{
    public class Pets : IBirthable, IName
    {
        public Pets(string birthdate, string name)
        {
            this.Birthdate = DateTime.ParseExact(birthdate, "dd/MM/yyyy", null);
            this.Name = name;
        }

        public DateTime Birthdate { get; private set; }
        public string Name { get; private set; }
    }
}
