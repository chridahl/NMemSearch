using System;
using Xunit;
using NMemDataStructures;

namespace NMemAllTests
{
    public class NMBinaryTests
    {
        [Fact]
        public void CanAppendBytes()
        {
            var subject = new NMemBinary();
            subject.Append(new byte[] { 0, 0, 0, 1});
            subject.Append(new byte[] { 9 });
            var values = subject.GetValue();

            Assert.Equal(values, new byte[]{0, 0, 0, 1, 9});
        }
    }
}
