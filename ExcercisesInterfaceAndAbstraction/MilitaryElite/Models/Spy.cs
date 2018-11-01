using MilitaryElite.Contracts;
using System;
using System.Text;

namespace MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeNum) : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNum;
        }

        public int CodeNumber { get; private set; }

        public decimal Salary => throw new NotImplementedException();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .AppendLine($"Code Number: {CodeNumber}");

            return sb.ToString();
        }
    }
}
