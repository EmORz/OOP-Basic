using SoftUniTimer.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SoftUniTimer.Core.Commands
{
    public class HibernateCommand : ICommands
    {
        public string Execute()
        {
            Process.Start("shutdown", $"/h");
            return null;
        }
    }
}
