using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_6_ValidPerson
{
    public class Person
    {
        //: first name (string), last name (string) and age (int).
        private string firstName;
        private string lastName;
        private int age;

        public Person(int age, string lastName, string firstName)
        {
            this.Age = age;
            this.LastName = lastName;
            this.FirstName = firstName;
        }

        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 0 || value>120)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Age should be in the range [0 ... 120].");
                }
                age = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "The last name cannot be null or empty");
                }

                lastName = value;
            }
        }
        public string FirstName
        {
            get { return firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "The first name cannot be null or empty");
                }
                firstName = value;
            }
        }

    }
}
