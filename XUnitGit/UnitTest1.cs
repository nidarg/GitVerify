using System;
using Xunit;

namespace XUnitGit
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3,5,8)]
        public void TestAdd(int x,int y,int expected)
        {
            int actual = x+y;
            Assert.Equal(expected,actual);
        }
    }
}
