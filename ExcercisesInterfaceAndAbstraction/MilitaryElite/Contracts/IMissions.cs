using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracts
{
    public interface IMissions
    {
        string Name { get; }
        string State { get; }

        void CompleteMissions();
    }
}
