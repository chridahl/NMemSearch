using System.Collections;
using NMemDataStructures;
using NMemDataStructures.Interfaces;

namespace NMemSearch
{
    public class NMemStorageUnit
    {
        // Storage unit to contain two
        ArrayList dataValues;

        public NMemStorageUnit()
        {
            dataValues = new ArrayList();
        }

        public NMemIndexEntity IndexAndAddDataValue<T>(INMemDataValue<T> dataValue)
        {
            var indexedEntity = new NMemIndexEntity();

            // This is bad...
            if (dataValue.GetType().Equals(typeof(NMemPlainText)))
            {
                indexedEntity.Index(((NMemPlainText)dataValue).GetValue().ToString());
            }
            else if (dataValue.GetType().Equals(typeof(NMemBinary)))
            {
                indexedEntity.Index(((NMemBinary)dataValue).GetValue());
            }

            AddDataValue<T>(dataValue);

            return indexedEntity;
        }

        public void AddDataValue<T>(INMemDataValue<T> dataValue)
        {

        }
    }
}
