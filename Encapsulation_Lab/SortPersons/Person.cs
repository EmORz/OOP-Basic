﻿namespace PersonsInfo
{
    public class Person
    {
        private string firstName = "";
        private string lastName = "";
        private int age = 0;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName= firstName;
            this.lastName = lastName;
            this.age = age;
        }
        //
        public string FisrtsName => this.firstName ;
        public string LastName => this.lastName;
        public int Age => this.age;
 
        public override string ToString()
        {
            return $"{this.FisrtsName} {this.LastName} is {this.Age} years old.";
        }



    }
}
