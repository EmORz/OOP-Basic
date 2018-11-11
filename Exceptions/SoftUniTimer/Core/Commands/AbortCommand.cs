using SoftUniTimer.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SoftUniTimer.Core.Commands
{
    public class AbortCommand : ICommands
    {
        public string Execute()
        {
            Process.Start("shutdown", $"/a");
            return "Commands abort successfully!";
        }
    }
}
