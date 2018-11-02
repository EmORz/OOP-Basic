using BorderControlUpdate.Contracts;

namespace BorderControlUpdate.Models
{
    public class Citizens : IIdentifable, IBirthable
    {
        private string id;
        private string name;
        private int age;
        private string birthday;

        public Citizens(string id, string name, int age, string birthday)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Birthday = birthday;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Birthday { get => birthday; private set => birthday = value; }

    }
}
