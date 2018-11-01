using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracts
{
    interface ISpy : IPrivate
    {
        int CodeNumber { get; }
    }
}
