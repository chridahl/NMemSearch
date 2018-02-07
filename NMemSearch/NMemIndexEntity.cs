using System;

namespace NMemSearch
{
    public class NMemIndexEntity
    {
        string[] tokens;

        public NMemIndexEntity()
        {
            //tokens = new string[1];
        }

        public void Index(string dataValue)
        {
            var words = dataValue.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var counter = 0;

            tokens = new string[words.Length];

            foreach (string word in words)
            {
                // stem
                tokens[counter] = word;
                counter++;
            }
        }

        public void Index(byte[] dataValue)
        {
            tokens = new string[10];
        }

        public string[] GetTokens()
        {
            return tokens;
        }
    }
}
