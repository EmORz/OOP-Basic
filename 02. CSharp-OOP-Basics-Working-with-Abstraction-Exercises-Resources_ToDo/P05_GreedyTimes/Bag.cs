using System;
using System.Collections.Generic;
using System.Text;

namespace P05_GreedyTimes
{
    class Bag
    {

        public static Dictionary<string, Dictionary<string, long>> bags = new Dictionary<string, Dictionary<string, long>>();
        private string name;
        private string whatIsThis;
        private long values;


        public Bag()
        {

        }
        public Bag(string name, string whatIsThis, long values)
        {
            this.Name = name;
            this.WhatIsThis = whatIsThis;
            this.Values = values;
        }




        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public long Values
        {
            get { return values; }
            set { values = value; }
        }
        public string WhatIsThis
        {
            get { return whatIsThis; }
            set { whatIsThis = value; }
        }



    }
}
