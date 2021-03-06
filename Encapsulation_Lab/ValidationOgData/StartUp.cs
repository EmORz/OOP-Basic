﻿namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;


    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                decimal salary = decimal.Parse(input[3]);
                //
                try
                {
                    Person current = new Person(firstName, lastName, age, salary);
                    persons.Add(current);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                
            }

            int bonus = int.Parse(Console.ReadLine());

            persons.ForEach(x => x.IncreaseSalary(bonus));
            persons.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}
