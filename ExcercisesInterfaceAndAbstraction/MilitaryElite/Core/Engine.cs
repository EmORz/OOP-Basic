using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite.Core
{
    public class Engine
    {
        private List<Soldier> soldiers = new List<Soldier>();
        public void Run()
        {
            string command = Console.ReadLine();
            while (command != "End")
            {
                var tokens = command.Split();
                var type = tokens[0].ToLower();

                switch (type)
                {
                    case "private":
                        Private @private = new Private(tokens[1], tokens[2], tokens[3], decimal.Parse(tokens[4]));
                        soldiers.Add(@private);
                        break;
                    case "leutenantgeneral":
                        LieutenantGeneral lieutenantGeneral = new LieutenantGeneral(tokens[1], tokens[2], tokens[3], decimal.Parse(tokens[4]));
                        for (int i = 5; i < tokens.Length; i++)
                        {
                            Private privat = (Private)soldiers.Single(s => s.Id == tokens[i]);
                            lieutenantGeneral.AddPrivate(privat);
                        }
                        soldiers.Add(lieutenantGeneral);
                        break;
                    case "commando": //TODO - Add implementation
                        break;
                    case "engineer":  //TODO - Add implementation
                        break;
                    case "spy":
                        Spy spy = new Spy(tokens[1], tokens[2], tokens[3], int.Parse(tokens[4]));
                        soldiers.Add(spy);
                        break;
               
                    default:
                        break;
                }


                command = Console.ReadLine();
            }
        }
    }
}
