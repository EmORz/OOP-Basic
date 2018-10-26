using System;

namespace Mankind
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get => firstName; set
            {
                if (!char.IsUpper(value[0]))
                {
                    Exception ex = new ArgumentException($"Expected upper case letter! Argument: {value}");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                if (value.Length<3)
                {
                    Exception ex = new ArgumentException($"Expected length at least 4 symbols! ! Argument: {value}");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get => lastName; set
            {
                if (!char.IsUpper(value[0]))
                {
                    Exception ex = new ArgumentException($"Expected upper case letter! Argument: {value}");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                if (value.Length < 2)
                {
                    Exception ex = new ArgumentException($"Expected length at least 4 symbols! ! Argument: {value}");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                lastName = value;
            }
        }
    }
}
