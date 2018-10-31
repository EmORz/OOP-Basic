using FootShortage.Contracts;
using FootShortage.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FootShortage.Core
{
    public class Engine
    {
        public void Run()
        {
            List<IBuyer> buyers = new List<IBuyer>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();

                if (tokens.Length == 4)
                {
                    buyers.Add(new Citizens(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]));
                }
                else if (tokens.Length == 3)
                {
                    buyers.Add(new Rebels(tokens[0], int.Parse(tokens[1]), tokens[2]));

                }
            }
            string commands = Console.ReadLine();

            while (commands !="End")
            {
                var buyer = buyers.SingleOrDefault(x => x.Name == commands);

                if (buyer!=null)
                {
                    buyer.Buyfood();
                }

                commands = Console.ReadLine();
            }
            var temp = buyers.Sum(x => x.Food);
            Console.WriteLine(temp);

        }
    }
}
