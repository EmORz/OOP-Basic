namespace ShoppingSpree
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] inputPerson = Console.ReadLine().Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string[] inputProduct = Console.ReadLine().Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            AddDataPerson(people, inputPerson);
            AddDataProducts(products, inputProduct);

            string input = Console.ReadLine();

            while (input !="END")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var person = tokens[0];
                var product = tokens[1];

                Product temp = products.First(p => p.Name == product);

                people.First(x => x.Name == person).Add(temp);

                input = Console.ReadLine();
            }
            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }


        }

        private static void AddDataProducts(List<Product> products, string[] product)
        {
            for (int i = 0; i < product.Length; i++)
            {
                string[] tokens = product[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var cost = decimal.Parse(tokens[1]);
                Product temp = new Product(name, cost);
                products.Add(temp);
            }
        }

        private static void AddDataPerson(List<Person> people, string[] person)
        {
            for (int i = 0; i < person.Length; i++)
            {
                string[] tokens = person[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var money = decimal.Parse(tokens[1]);
                Person temp = new Person(name, money);
                people.Add(temp);
            }
        }
    }
}
