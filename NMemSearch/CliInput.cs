using System;
using System.Collections.Generic;

namespace NMemSearch
{
    public class CliInput
    {
        readonly string Input = String.Empty;
        public CliInput(string Input) => this.Input = Input;

        public Dictionary<string, string> GetOptions()
        {
            var options = new Dictionary<string, string>();
            var parameters = this.Input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in parameters)
            {
                if (!word.Contains("="))
                    continue;

                var parm = word.Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                options[parm[0]] = parm[1];
            }

            return options;
        }
    }
}
