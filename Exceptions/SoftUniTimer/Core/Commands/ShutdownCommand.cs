using SoftUniTimer.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using SoftUniTimer.Extensions;

namespace SoftUniTimer.Core.Commands
{
    public class ShutdownCommand : ICommands
    {
        private string[] inputArg;

        public ShutdownCommand(string[] inputArg)
        {
            this.inputArg = inputArg;
        }

        public string Execute()
        {
            if (inputArg.Length<1 || string.IsNullOrEmpty(inputArg[0]))
            {
                throw new ArgumentNullException("Parameters count mismatch!");
            }
            int minutes = int.Parse(inputArg[0]);
            int seconds = int.Parse(inputArg[0]).ToSeconds();
            Process.Start("shutdown", $"/s /t {seconds}");

            return $"Windows will shutdown after {minutes} minutes";

        }
    }
}
