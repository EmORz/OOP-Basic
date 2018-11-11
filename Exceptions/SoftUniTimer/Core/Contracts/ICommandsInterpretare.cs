using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniTimer.Core.Contracts
{
    public interface ICommandsInterpretare
    {
        string Reads(string[] inputAgs);
    }
}
