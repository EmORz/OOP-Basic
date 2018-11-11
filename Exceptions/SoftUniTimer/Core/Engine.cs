using SoftUniTimer.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniTimer.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandsInterpretare commandsInterpretare;

        public Engine(ICommandsInterpretare commandsInterpretare)
        {
            this.commandsInterpretare = commandsInterpretare;
        }
        public void Run()
        {
            while (true)
            {
                try
                {
                    string[] inputArgs = Console.ReadLine().ToLower().Split();
                    this.commandsInterpretare.Reads(inputArgs);
                    var result = commandsInterpretare;
                    Console.WriteLine(result);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
         


            }
        }
    }
}
