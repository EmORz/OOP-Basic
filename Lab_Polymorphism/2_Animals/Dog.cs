﻿using System;
using System.Text;

namespace Animals
{
    internal class Dog : Animal
    {
        public Dog(string name, string favouriteFood)
        : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            var builder = new StringBuilder();
            builder.AppendLine(base.ExplainSelf())
                .Append("DJAAF");
            return builder.ToString();
        }
    }
}
