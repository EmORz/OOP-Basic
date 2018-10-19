using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class People
    {
        public string Name { get; set; }
        public Company company;
        public Car car;
        public List<Pokemon> pokemon;
        public List<Parents> parents;
        public List<Children> children;

        public People(string name)
        {
            this.Name = name;
            this.company = null;
            this.car = null;
            this.pokemon = new List<Pokemon>();
            this.parents = new List<Parents>();
            this.children = new List<Children>();
        }
    }
}
