using System.Collections.Generic;

namespace NMemSearch
{
    public class NMemMemoryStorage
    {
        List<NMemStorageUnit> storageUnits;

        public NMemMemoryStorage()
        {
            storageUnits = new List<NMemStorageUnit>();
        }

        public int GetStoredUnits()
        {
            return storageUnits.Count;
        }

        public void AddStorageUnit(NMemStorageUnit storageUnit)
        {
            storageUnits.Add(storageUnit);
        }
    }
}
