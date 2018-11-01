using BirthdayCelebrations.Contracts;
using System;

namespace BirthdayCelebrations.Models
{
    public class Citizens : IBirthable, IIdentity, IName
    {
        private int age;
        public Citizens(string birthdate, string id, string name, int age)
        {
            this.Birthdate = DateTime.ParseExact(birthdate, "dd/MM/yyyy", null);
            this.Id = id;
            this.age = age;
            this.Name = name;
        }

        public DateTime Birthdate { get; private set; }

        public string Id { get; private set; }

        public string Name { get; private set; }
    }
}
