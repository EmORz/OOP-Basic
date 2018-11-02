using BorderControlUpdate.Contracts;

namespace BorderControlUpdate.Models
{
    public class Citizens : IIdentifable
    {
        private string id;
        private string name;
        private int age;

        public Citizens(string id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
}
