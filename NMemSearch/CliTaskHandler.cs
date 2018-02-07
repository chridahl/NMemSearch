using System;
using System.Collections.Generic;

namespace NMemSearch
{
    public class CliTaskHandler
    {
        readonly NMemServer nmemServer;

        public CliTaskHandler(NMemServer server)
        {
            nmemServer = server;
        }

        public void oy(CliInput cliInput)
        {
            var options = cliInput.GetOptions();
            foreach (KeyValuePair<string, string> s in options)
            {
                Console.WriteLine($"{s.Key}:{s.Value}");
            }
        }

        public void LoadTextFile(CliInput cliInput)
        {
        }

        public void LoadBinaryFile(CliInput cliInput)
        {
        }

        public void Search(CliInput cliInput)
        {
        }

        public void ShowStats(CliInput cliInput)
        {
            var serverStats = nmemServer.GetStats();

            Console.WriteLine("Server stats:");
            Console.WriteLine($"\t  name \t\t {serverStats.Name}");
            Console.WriteLine($"\t  version \t {serverStats.Version}");
            Console.WriteLine($"\t  num units \t {serverStats.UnitsIndexed}");
        }

        public void ShowHelp(CliInput cliInput)
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("\t  help \t\t shows the commands");
            Console.WriteLine("\t  stat \t\t shows nmemserver stats");
            Console.WriteLine("\t  ltf [file] \t loads and indexes a text file");
            Console.WriteLine("\t  lbf [file] \t loads and indexes a binary file");
            Console.WriteLine("\t  s [query] \t searches for query");
            Console.WriteLine("\t  oy [options] \t just for testing");
            Console.WriteLine("\t  q \t\t quits program");
            Console.WriteLine(String.Empty);
            Console.WriteLine("\t Sample command: oy parm1=val1 parm2=val2");
        }
    }
}
