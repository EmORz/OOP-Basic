namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;   

        public Person(string firstName, string secondName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = secondName;
            this.age = age;
            this.salary = salary;
        }
        public string FirstName => this.firstName ="";
        public int Age => this.age = 0;
        public string LastName => this.lastName = "";
        public decimal Salary => this.salary = 0;

        public void IncreaseSalary(decimal bonusPercents)
        {
            if (this.age < 30)
            {
                this.salary += salary*(bonusPercents/200);
            }
            else
            {
                this.salary += (salary*(bonusPercents/100));
            }
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} receives {this.salary:f2} leva.";
        }










    }
}
