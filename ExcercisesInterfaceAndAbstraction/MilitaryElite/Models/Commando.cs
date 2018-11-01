using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private List<Missions> missions;
        public Commando(string id, string firstName, string lastName, decimal salary, string corps) :
            base(id, firstName, lastName, salary, corps)
        {
            this.missions = new List<Missions>();
        }

        public IReadOnlyCollection<IMissions> Missions => this.missions;
        public void AddMissions(Missions missions)
        {
            this.missions.Add(missions);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .AppendLine("Missions:");
            this.missions.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }

    }
}
