using System;
using Xunit;
using NMemDataStructures;
using System.Text;
using NMemSearch;

namespace NMemAllTests
{
    public class NMemStorageUnitTests
    {
        [Fact]
        public void CanAddItemToStorage()
        {
            var dataValue = new NMemPlainText();
            dataValue.Append(new StringBuilder("These are words"));

            var subject = new NMemStorageUnit();
            var indexedEntity = subject.IndexAndAddDataValue(dataValue);
            var result = indexedEntity.GetTokens();

            Assert.Equal(new string[] { "These", "are", "words"}, result);           
        }
    }
}
