using System;
using System.Collections.Generic;

namespace NMemSearch
{
    
    class Program
    {
        public void Start()
        {
            var cliTaskHandler = new CliTaskHandler(new NMemServer());

            var allowedCommands = new Dictionary<string, Action<CliInput>>();
            allowedCommands.Add("oy", new Action<CliInput>(c => cliTaskHandler.oy(c)));
            allowedCommands.Add("ltf", new Action<CliInput>(c => cliTaskHandler.LoadTextFile(c)));
            allowedCommands.Add("lbf", new Action<CliInput>(c => cliTaskHandler.LoadBinaryFile(c)));
            allowedCommands.Add("s", new Action<CliInput>(c => cliTaskHandler.Search(c)));
            allowedCommands.Add("stat", new Action<CliInput>(c => cliTaskHandler.ShowStats(c)));
            allowedCommands.Add("help", new Action<CliInput>(c => cliTaskHandler.ShowHelp(c)));

            var cli = new CommandLineInterface(allowedCommands);
            cli.RunStdinLoop();
        }

        static void Main(string[] args)
        {
            var p = new Program();
            p.Start();
        }
    }

}
