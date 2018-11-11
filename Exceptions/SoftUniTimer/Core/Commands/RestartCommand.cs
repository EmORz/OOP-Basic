using SoftUniTimer.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SoftUniTimer.Core.Commands
{
    public class RestartCommand : ICommands
    {
        private readonly string[] inputArg;

        public RestartCommand(string[] inputArgs)
        {
            this.inputArg = inputArgs;
        }

        public string Execute()
        {
            if (inputArg.Length < 1 || string.IsNullOrEmpty(inputArg[0]))
            {
                throw new ArgumentNullException("Parameters count mismatch!");
            }
            int minutes = int.Parse(inputArg[0]);
            Process.Start("shutdown", $"/r /t {minutes*60}");

            return $"Windows will restart after {minutes} minutes";
        }
    }
}
