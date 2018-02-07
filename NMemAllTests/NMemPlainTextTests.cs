using System;
using Xunit;
using NMemDataStructures;
using System.Text;

namespace NMemAllTests
{
    public class NMemPainTextTests
    {
        [Fact]
        public void CanAppendText()
        {
            var subject = new NMemPlainText();
            subject.Append(new StringBuilder("Cool"));
            subject.Append(new StringBuilder(" stuff!"));

            Assert.True(subject.GetValue().ToString().Equals("Cool stuff!"));
        }

        [Fact]
        public void CanClear()
        {
            var subject = new NMemPlainText();
            subject.Append(new StringBuilder("Cool"));
            subject.ClearValues();

            Assert.True(subject.GetValue().ToString().Equals(String.Empty));
        }
    }
}
