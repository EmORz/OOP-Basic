using BorderControlUpdate.Contracts;

namespace BorderControlUpdate.Models
{
    public class Pet: IBirthable
    {
        private string name;
        private string birthday;

        public Pet(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public string Name { get => name; private set => name = value; }
        public string Birthday { get => birthday; private set => birthday = value; }
    }
}
