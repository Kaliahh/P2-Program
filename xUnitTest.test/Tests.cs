using System;
using p2_program;
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
        public void TestHans()
        {
            Hans hans = new Hans();
            
            Assert.True(hans.Noget());
        }
    }
}