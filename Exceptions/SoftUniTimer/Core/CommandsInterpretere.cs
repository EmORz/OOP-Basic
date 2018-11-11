using SoftUniTimer.Core.Commands;
using SoftUniTimer.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniTimer.Core
{
    public class CommandsInterpretere : ICommandsInterpretare
    {
        private ICommands commands;

        public string Reads(string[] inputAgs)
        {
            var action = inputAgs[0].ToLower();
            inputAgs = inputAgs.Skip(1).ToArray();
            switch (action)
            {
                case "shutdown":
                    commands = new ShutdownCommand(inputAgs);
                    break;
                case "restart":
                    commands = new RestartCommand(inputAgs);
                    break;
                case "hibernate":
                    commands = new HibernateCommand();
                    break;
                case "abort":
                    commands = new AbortCommand();
                    break;
                case "exit":
                    commands = new ExitCommand();
                    break;
                default:
                    break;
            }
            if (commands == null)
            {
                throw new ArgumentException("Command is not supported!");
            }
            var result = commands.Execute();
            return result;
        }
    }
}
