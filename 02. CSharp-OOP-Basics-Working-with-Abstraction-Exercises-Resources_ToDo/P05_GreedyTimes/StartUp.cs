using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class StartUp
    {
        static void Main(string[] args)
        {
            long bagCapacity = long.Parse(Console.ReadLine());
            string[] valueInSeif = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var bag = Bag.bags;
            long gold = 0;
            long gems = 0;
            long money = 0;
            string[] what = {"Cash", "Gem", "Gold" };
            
            for (int i = 0; i < valueInSeif.Length; i += 2)
            {
                string name = valueInSeif[i];
                long count = long.Parse(valueInSeif[i + 1]);

                string whatIs = string.Empty;

                if (name.Length == 3)
                {
                    whatIs = what[0];
                }
                else if (name.ToLower().EndsWith("gem"))
                {
                    whatIs = what[1];
                }
                else if (name.ToLower() == "gold")
                {
                    whatIs = what[2];
                }

                if (whatIs == "")
                {
                    continue;
                }
                else if (IsOutOfBorder(bagCapacity, bag, count))
                {
                    continue;
                }
                string goldOrGem = "";
                switch (whatIs)
                {
                    case "Gem":
                        goldOrGem = what[2];
                        if (!bag.ContainsKey(whatIs))
                        {
                            if (bag.ContainsKey(goldOrGem))
                            {
                                if (IsBagEhought(bag, count, goldOrGem))
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (CheckBagCapacity(bag, count, whatIs, goldOrGem))
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        goldOrGem = what[1];
                        if (!bag.ContainsKey(whatIs))
                        {
                            if (bag.ContainsKey(goldOrGem))
                            {
                                if (IsBagEhought(bag, count, goldOrGem))
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (CheckBagCapacity(bag, count, whatIs, goldOrGem))
                        {
                            continue;
                        }
                        break;
                }

                if (!bag.ContainsKey(whatIs))
                {
                    bag[whatIs] = new Dictionary<string, long>();
                }

                if (!bag[whatIs].ContainsKey(name))
                {
                    bag[whatIs][name] = 0;
                }

                bag[whatIs][name] += count;
                if (whatIs == what[2])
                {
                    gold += count;
                }
                else if (whatIs == what[1])
                {
                    gems += count;
                }
                else if (whatIs == what[0])
                {
                    money += count;
                }
            }

            foreach (var x in bag)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
                foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }

        private static bool IsBagEhought(Dictionary<string, Dictionary<string, long>> bag, long count, string goldOrGem)
        {
            return count > bag[goldOrGem].Values.Sum();
        }

        private static bool CheckBagCapacity(Dictionary<string, Dictionary<string, long>> bag, long count, string whatIs, string goldOrGem)
        {
            return bag[whatIs].Values.Sum() + count > bag[goldOrGem].Values.Sum();
        }

        private static bool IsOutOfBorder(long bagCapacity, Dictionary<string, Dictionary<string, long>> bag, long count)
        {
            return bagCapacity < bag.Values.Select(x => x.Values.Sum()).Sum() + count;
        }
    }
}