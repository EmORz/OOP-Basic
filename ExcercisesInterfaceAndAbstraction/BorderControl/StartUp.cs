using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> ids = new HashSet<string>();
            while (input != "End")
            {
                var tokens = input.Split();
                if (tokens.Length == 3)
                {                    
                    ids.Add(tokens[2]);
                }
                if (tokens.Length == 2)
                {                    
                    ids.Add(tokens[1]);
                }
                input = Console.ReadLine();
            }    
            var num = int.Parse(Console.ReadLine()) % 100;
            foreach (var item in ids)
            {
                int number = int.Parse(item.Substring(item.Length - 2, 2));
                if (num==number)
                {
                    Console.WriteLine(item);
                }
            }


        }
    }
}
