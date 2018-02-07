using System;
using System.Collections.Generic;

namespace NMemSearch
{
    public class CommandLineInterface
    {
        readonly Dictionary<string, Action<CliInput>> _allowedCommands;

        public CommandLineInterface(Dictionary<string, Action<CliInput>> allowedCommands)
        {
            _allowedCommands = allowedCommands;
        }

        public void RunStdinLoop()
        {
            var runLoop = true;

            while (runLoop)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Command: ");
                Console.ForegroundColor = ConsoleColor.White;

                var command = Console.ReadLine();
                var input = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                if (_allowedCommands.ContainsKey(input[0]))
                {
                    var cliInput = new CliInput(string.Join(" ", input));
                    _allowedCommands[input[0]].DynamicInvoke(cliInput);
                }

                if (command.Equals("q"))
                {
                    Console.WriteLine("Exiting...");
                    runLoop = false;
                }
            }
        }
    }
}
