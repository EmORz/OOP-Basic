using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Missions : IMissions
    {
        private MIssionState state;

        public Missions(string name, string state)
        {
            this.Name = name;
            this.State = state;
        }

        public string Name { get; private set; }

        public string State
        {
            get
            {
                return this.state.ToString();
            }
            private set
            {
                MIssionState state;

                if (!Enum.TryParse<MIssionState>(value, out state))
                {
                    throw new ArgumentException();

                }
                this.state = state;
            }
        }

        public void CompleteMissions()
        {
            this.state = MIssionState.Finished;
        }

        public override string ToString()
        {            
            return $"  Code Name: {this.Name} State: {this.State}";
        }

    }
}
