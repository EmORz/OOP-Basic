using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Employee[] data = new Employee[count];

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                decimal salary = decimal.Parse(tokens[1]);
                string position = tokens[2];
                string department = tokens[3];

                if (tokens.Length == 4)
                {
                    data[i] = new Employee(name, salary, position, department);
                }
                else if (tokens.Length == 5)
                {
                    int age;
                    bool isAge = int.TryParse(tokens[4], out age);
                    if (isAge)
                    {
                        data[i] = new Employee(name, salary, position, department, age);

                    }
                    else
                    {
                        string email = tokens[4];
                        data[i] = new Employee(name, salary, position, department, email);

                    }
                    
                }
                else
                {
                    string email = tokens[4];
                    int age = int.Parse(tokens[5]);
                    data[i] = new Employee(name, salary, position, department, email, age);

                }
            }
            Dictionary<string, decimal> totalSalary = new Dictionary<string, decimal>();

            foreach (var emplayee in data)
            {
                if (totalSalary.ContainsKey(emplayee.department))
                {
                    totalSalary[emplayee.department] += emplayee.salary;
                }
                else
                {
                    totalSalary[emplayee.department] = emplayee.salary;
                }
            }
            var highestAvaregeSalary = decimal.MinValue;
            var highestDepartment = "";

            foreach (string department in totalSalary.Keys)
            {
                var average = totalSalary[department] / data.Where(x => x.department == department).Count();
                if (average>highestAvaregeSalary)
                {
                    highestAvaregeSalary = average;
                    highestDepartment = department;
                }
            }
            Console.WriteLine($"Highest Average Salary: {highestDepartment}");

            foreach (var item in data.Where(x => x.department == highestDepartment).OrderByDescending(c => c.salary))
            {
                string temp = item.name + " " + $"{item.salary:f2}" + " " + item.email + " " + item.age;
                Console.WriteLine(temp);
            }


        }
    }
}
