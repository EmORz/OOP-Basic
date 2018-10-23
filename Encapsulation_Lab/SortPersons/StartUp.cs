namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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
                //
                Person current = new Person(firstName, lastName, age);
                persons.Add(current);
            }
            persons.OrderBy(p => p.FisrtsName).ThenBy(a => a.Age).ToList().ForEach(per => Console.WriteLine(per.ToString())) ;
        }
    }
}
