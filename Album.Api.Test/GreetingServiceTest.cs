using Album.Api.Services;
using System;
using Xunit;

namespace Album.Api.Test
{
    public class GreetingServiceTest
    {
        [Fact]
        public void NameInputTest()
        {
            var name = "TestName";

            var result = GreetingService.checkParameter(name);

            Assert.Equal("Hello TestName", result);
        }

        [Fact]
        public void NullInputTest()
        {
            string name = null;

            var result = GreetingService.checkParameter(name);

            Assert.Equal("Hello World", result);
        }

        [Fact]
        public void EmptyInputTest()
        {
            string name = string.Empty;

            var result = GreetingService.checkParameter(name);

            Assert.Equal("Hello World", result);
        }

        [Fact]
        public void WhiteSpaceInputTest()
        {
            string name = " ";

            var result = GreetingService.checkParameter(name);

            Assert.Equal("Hello World", result);
        }
    }
}
