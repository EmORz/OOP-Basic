using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class OpinionPoll: Person
    {
        public static List<OpinionPoll> data = new List<OpinionPoll>();


        public OpinionPoll() { }
        public OpinionPoll(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public void AddPerson(int age, string name)
        {
            data.Add(new OpinionPoll(age, name));
        }
        public void OldestThanThirty()
        {
            var getOldest = data.OrderBy(x => x.Name).Where(x => x.Age > 30);
            foreach (var person in getOldest)
            {
                Console.WriteLine(person.Name+" - "+person.Age);
            }
        }
    }
}
