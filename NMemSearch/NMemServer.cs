using System;
using System.Collections.Generic;

namespace NMemSearch
{
    public class NMemServer
    {
        NMemMemoryStorage storage;

        public NMemServer()
        {
            storage = new NMemMemoryStorage();
        }

        public NMemServerStats GetStats()
        {
            return new NMemServerStats()
            {
                Name = "Toby the NMemServer",
                Version = "pre-alpha",
                UnitsIndexed = storage.GetStoredUnits().ToString()
            };
            
        }
    }
}
