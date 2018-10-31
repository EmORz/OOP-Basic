using FootShortage.Contracts;
using System;

namespace FootShortage.Model
{
    public class Citizens : IBirthtable, IAge, IBuyer, IIdentiable
    {
        public Citizens(string name, int age,  string id,  string birthtime)
        {
            this.Age = age;
            this.Name = name;
            this.Id = id;
            this.Birthtime = DateTime.ParseExact(birthtime, "dd/MM/yyyy", null);
        }

        public int Age { get; private set; }
        public string Name { get; private set; }
        public int Food { get; private set; }

        public string Id { get; private set; }

        public DateTime Birthtime { get; private set; }

        public void Buyfood()
        {
            this.Food += 10;
        }
    }
}
