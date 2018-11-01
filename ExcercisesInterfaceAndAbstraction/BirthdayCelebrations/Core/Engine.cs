using BirthdayCelebrations.Contracts;
using BirthdayCelebrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations.Core
{
    public class Engine
    {
        public void Run()
        {
            List<IBirthable> list = new List<IBirthable>();
            string command = Console.ReadLine();

            while (command !="End")
            {


                string[] tokens = command.Split();
                string type = tokens[0].ToLower();

                switch (type)
                {
                    case "citizen":
                        list.Add(new Citizens(tokens[4], tokens[3], tokens[1], int.Parse(tokens[2])));
                        break;
                    case "pet":
                        list.Add(new Pets(tokens[2], tokens[1]));
                        break;                  
                }
                command = Console.ReadLine();
            }
            int year = int.Parse(Console.ReadLine());
            var printData = list.Where(x => x.Birthdate.Year == year)
                .Select(x => x.Birthdate);

            foreach (var date in printData)
            {
                Console.WriteLine($"{date.Day:d2}/{date.Month:d2}/{date.Year}");
            }
                
        }
    }
}
