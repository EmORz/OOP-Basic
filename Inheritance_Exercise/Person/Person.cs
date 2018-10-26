namespace Person
{
    using System;
    using System.Text;

    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
           this.Name = name;
           this.Age = age;
        }

        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length<3)
                {
                    Exception exception = new ArgumentException("Name's length should not be less than 3 symbols!");
                    Console.WriteLine(exception.Message);
                    Environment.Exit(0);
                }
                name = value;
            }
        }
        public virtual int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value<0)
                {
                    Exception exception = new ArgumentException("Age must be positive!");
                    Console.WriteLine(exception.Message);
                    Environment.Exit(0);
                }
                age = value;
            }
        }

        //
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format($"Name: {this.Name}, Age: {this.Age}"));
            return sb.ToString();
        }
    }
}
