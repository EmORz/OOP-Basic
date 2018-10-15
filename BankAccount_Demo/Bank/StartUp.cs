using System;
using System.Collections.Generic;
using System.Linq;

namespace BankAccount
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //var data = new Dictionary<int, BankAccount>();

            //while (true)
            //{
            //    string[] tokens = Console.ReadLine().Split();
            //    if (tokens[0] !="End")
            //    {
            //        switch (tokens[0])
            //        {
            //            case "Create":
            //                Create(tokens, data);
            //                break;
            //            case "Deposit":
            //                Deposit(tokens, data);
            //                break;
            //            case "Withdraw":
            //                Withdraw(tokens, data);
            //                break;
            //            case "Print":
            //                Print(tokens, data);
            //                break;
            //            default:
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
        }

        private static void Print(string[] tokens, Dictionary<int, BankAccount> data)
        {
            var id = int.Parse(tokens[1]);
            if (data.ContainsKey(id))
            {
                foreach (var clientInfo in data)
                {
                    if (clientInfo.Key == id)
                    {
                        Console.WriteLine(clientInfo.Value.ToString());
                    }
                }
            
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Withdraw(string[] tokens, Dictionary<int, BankAccount> data)
        {
            var id = int.Parse(tokens[1]);
            var money = int.Parse(tokens[2]);

            if (!data.ContainsKey(id))
            {                
                Console.WriteLine("Account does not exist");
            }
            else if (data[id].Balance < money)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                data[id].Balance -= money;
            }
        }

        private static void Deposit(string[] tokens, Dictionary<int, BankAccount> data)
        {
            var id = int.Parse(tokens[1]);
            var money = int.Parse(tokens[2]);

            if (data.ContainsKey(id))
            {
                data[id].Balance += money;
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Create(string[] tokens, Dictionary<int, BankAccount> data)
        {
            var temp = int.Parse(tokens[1]);
            if (data.ContainsKey(temp))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                data.Add(temp, new BankAccount { ID = temp });

            }
        }
    }
}
