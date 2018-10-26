namespace Person
{
    using System;

    public class Child: Person
    {
        public Child(string name, int age): base(name, age)
        {

        }
        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (value > 15)
                {
                    Exception exception = new ArgumentException("Child's age must be less than 15!");
                    Console.WriteLine(exception.Message);
                    Environment.Exit(0);
                }
                base.Age = value;
            }
        }
    }
}
