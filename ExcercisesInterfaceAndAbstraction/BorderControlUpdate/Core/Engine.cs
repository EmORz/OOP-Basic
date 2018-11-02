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
        private List<IBirthable> birthables = new List<IBirthable>();
        //1. BorderControl
        //2. BirthdayCelebrations => extend version
        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgs = input.Split();

                if (inputArgs[0].ToLower() == "robot")
                {
                    string model = inputArgs[1];
                    string id = inputArgs[2];
                    Robots robots = new Robots(id, model);
                    identifables.Add(robots);
                }
                else if (inputArgs[0].ToLower() == "citizen")
                {
                    string name = inputArgs[1];
                    int age = int.Parse(inputArgs[2]);
                    string id = inputArgs[3];
                    string birthdate = inputArgs[4];

                    IBirthable citizens = new Citizens(id, name, age, birthdate);
                    birthables.Add(citizens);
                    
                }
                else if (inputArgs[0].ToLower() == "pet")
                {
                    string name = inputArgs[1];
                    string birthdate = inputArgs[2];
                    Pet pet = new Pet(name, birthdate);
                    birthables.Add(pet);
                }
                    input = Console.ReadLine();
            }
            string year = Console.ReadLine();
            birthables.Where(x => x.Birthday.EndsWith(year)).ToList().ForEach(x => Console.WriteLine(x.Birthday)) ;
           
        }
    }
}
