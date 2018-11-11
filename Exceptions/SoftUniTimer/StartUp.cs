using SoftUniTimer.Core;
using SoftUniTimer.Core.Contracts;
using System;

namespace SoftUniTimer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICommandsInterpretare commandsInterpretare = new CommandsInterpretere();
            IEngine engine = new Engine(commandsInterpretare);
            engine.Run();
        }
    }
}
