namespace PersonsInfo
{
    using System;

    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }   

        public string FirstName
        {
            get { return firstName; }
            private set
            {
                if (value.Length<3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Second name cannot contain fewer than 3 symbols!");
                }
                lastName = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0 )
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                age = value;
                
            }
        }
        public decimal Salary
        {
            get { return this.salary; }
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
                else
                {
                    salary = value;
                }
            }
        }

        public void IncreaseSalary(decimal bonusPercents)
        {
            if (this.Age < 30)
            {
                this.Salary += Salary * (bonusPercents / 200);
            }
            else
            {
                this.Salary += (Salary * (bonusPercents / 100));
            }
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} gets {this.salary:f2} leva.";
        }

    }
}
