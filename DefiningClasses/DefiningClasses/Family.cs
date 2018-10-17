using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family: Person
    {
        public static List<Family> data = new List<Family>();

        public Family() { }

        public Family( int age, string name)
        {
            this.Name = name;
            this.Age = age;
        }
        public void AddMember(int age, string name)
        {
            data.Add(new Family(age, name));
        }

       public void GetOldestMember()
        {
            var temp = data.OrderByDescending(x => x.Age).Take(1);
            foreach (var item in temp)
            {
                Console.WriteLine(item.Name+" "+item.Age);
            }
        }


    }
}
