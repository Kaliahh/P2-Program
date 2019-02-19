using System;
using Xunit;

namespace xUnitTest.test
{
    public class Tests
    {
        [Fact]
        public void TestTrue()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestFalse()
        {
            Assert.False(false);
        }
    }
}