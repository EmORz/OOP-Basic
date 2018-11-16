using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Core
{
    public class Engine
    {
        private DungeonMaster dungeonMaster;

        public Engine()
        {
            dungeonMaster = new DungeonMaster();
        }
        public void Run()
        {
            string input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                string[] inptArgs = input.Split();

                var command = inptArgs[0];
                string[] args = inptArgs.Skip(1).ToArray();
                string result = "";

                try
                {
                    switch (command)
                    {
                        case "JoinParty":
                            result = dungeonMaster.JoinParty(args);
                            break;
                        case "AddItemToPool":
                            result = dungeonMaster.AddItemToPool(args);
                            break;
                        case "PickUpItem":
                            result = dungeonMaster.PickUpItem(args);
                            break;
                        case "UseItem":
                            result = dungeonMaster.UseItem(args);
                            break;
                        case "UseItemOn":
                            result = dungeonMaster.UseItemOn(args);
                            break;
                        case "GiveCharacterItem":
                            result = dungeonMaster.GiveCharacterItem(args);
                            break;
                        case "GetStats":
                            result = dungeonMaster.GetStats();
                            break;
                        case "Attack":
                            result = dungeonMaster.Attack(args);
                            break;
                        case "Heal":
                            result = dungeonMaster.Heal(args);
                            break;
                        case "EndTurn":
                            result = dungeonMaster.EndTurn(args);
                            break;
                        case "IsGameOver":
                            dungeonMaster.IsGameOver();
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine(result);
                }
                catch (InvalidOperationException invEx)
                {
                    Console.WriteLine($"Invalid Operation: {invEx.Message}");
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine($"Parameter Error: {ae.Message}");
                }

                if (dungeonMaster.IsGameOver())
                {
                    break;
                }



                input = Console.ReadLine();
            }
            Console.WriteLine("Final stats:");
            Console.WriteLine(dungeonMaster.GetStats());
        }
    }
}
