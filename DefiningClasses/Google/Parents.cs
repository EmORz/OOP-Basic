using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Parents
    {
        public string Name { get; set; }
        public string Birthday { get; set; }

        public Parents(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Birthday}";
        }
    }
}
