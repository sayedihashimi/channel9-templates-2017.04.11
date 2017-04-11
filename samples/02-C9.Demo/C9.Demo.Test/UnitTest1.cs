using System;
using Xunit;
using C9.Demo;

namespace C9.Demo.Test
{
    public class C9_Demo_UnitTest
    {
        [Fact]
        public void C9_Demo_Test()
        {
            var name = Sample.GetName();
            Assert.Equal("Channel 9 demo",name);
        }
    }
}
