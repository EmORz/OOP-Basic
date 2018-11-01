using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<Repair> repairs;
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps) :
            base(id, firstName, lastName, salary, corps)
        {
            this.repairs = new List<Repair>();
        }
        public IReadOnlyCollection<IRepair> Repairs { get;  }
        public void AddRepair(Repair repair)
        {
            this.repairs.Add(repair);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .AppendLine("Repairs:");
            foreach (var item in repairs)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().ToString();
        }
    }
}
