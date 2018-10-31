using FootShortage.Contracts;

namespace FootShortage.Model
{
    public class Rebels : IBuyer, IAge
    {
        private string group;
        public Rebels(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.group = group;
        }

        public string Name { get; private set; }

        public int Food { get; private set; }

        public int Age { get; private set; }

        public void Buyfood()
        {
            this.Food += 5;
        }
    }
}
