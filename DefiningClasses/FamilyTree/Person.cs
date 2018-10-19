using System.Collections.Generic;
using System.Linq;

namespace FamilyTree
{
    class Person
    {
        public string Name { get; set; }
        public string BirthDay { get; set; }

        public List<Person> child;
        public List<Person> parents;

        public Person(string name, string birthday)
        {
            this.Name = name;
            this.BirthDay = birthday;
            this.child = new List<Person>();
            this.parents = new List<Person>();
        }
        //
       

    }
}
