namespace PersonInfo
{
    public class Citizen : IBirthable, IIdentifiable
    {
        private string name;
        private int age;

        public Citizen(string name, int age, string id, string birthdate )
        {
            this.Name = name;
            this.Birthdate = birthdate;
            this.Id = id;
            this.Age = age;
        }

        public string Birthdate { get ; set ; }
        public string Id { get; set; }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
