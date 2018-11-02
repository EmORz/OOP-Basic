using BorderControlUpdate.Contracts;
using BorderControlUpdate.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControlUpdate.Core
{
    public class Engine
    {
        private List<IIdentifable> identifables = new List<IIdentifable>();
        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgs = input.Split();

                if (inputArgs.Length==2)
                {
                    string model = inputArgs[0];
                    string id = inputArgs[1];
                    Robots robots = new Robots(id, model);
                    identifables.Add(robots);                  
                }
                else
                {
                    string name = inputArgs[0];
                    int age = int.Parse(inputArgs[1]);
                    string id = inputArgs[2];
                    Citizens citizens = new Citizens(id, name, age);
                    identifables.Add(citizens);      
                }
                input = Console.ReadLine();
            }
            string fakeIds = Console.ReadLine();
            identifables.Where(x => x.Id.EndsWith(fakeIds)).ToList().ForEach(x => Console.WriteLine(x.Id)) ;
           
        }
    }
}
