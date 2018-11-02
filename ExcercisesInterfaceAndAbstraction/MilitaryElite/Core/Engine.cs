using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite.Core
{
    public class Engine
    {
        private List<Soldier> soldiers = new List<Soldier>();
        //TODO => 40/100 must be refactoring
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
                    case "commando": 
                        //<id> <firstName> <lastName> <salary> <corps> <mission1CodeName>  
                        try
                        {
                            Commando commando = new Commando(tokens[1], tokens[2], tokens[3], decimal.Parse(tokens[4]), tokens[5]);
                            for (int i = 6; i < tokens.Length; i+=2)
                            {
                                try
                                {
                                    Missions missions = new Missions(tokens[i], tokens[i + 1]);
                                    commando.AddMissions(missions);
                            }
                                catch (ArgumentException)
                                {

                                }
                            }
                            soldiers.Add(commando);    
                        }
                        catch (ArgumentException)
                        {

                        }
                        break;
                    case "engineer": 
                        try
                        {
                            //Engineer <id> <firstName> <lastName> <salary> <corps> <repair1Part> <repair1Hours> … <repairNPart> <repairNHours>
                            Engineer engineer = new Engineer(tokens[1], tokens[2], tokens[3], decimal.Parse(tokens[4]), tokens[5]);
                            for (int i = 6; i < tokens.Length; i+=2)
                            {
                                Repair repair = new Repair(tokens[i], int.Parse(tokens[i + 1]));
                                engineer.AddRepair(repair);
                            }
                            soldiers.Add(engineer);
                        }
                        catch (ArgumentException)
                        {

                        }
                        break;
                    case "spy":
                        Spy spy = new Spy(tokens[1], tokens[2], tokens[3], int.Parse(tokens[4]));
                        soldiers.Add(spy);
                        break;
                }
                command = Console.ReadLine();
            }
            soldiers.ForEach(Console.WriteLine);
        }
    }
}
