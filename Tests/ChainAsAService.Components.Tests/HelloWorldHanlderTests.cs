using System;
using Xunit;
using ChainAsAService.Components;
using ChainAsAService.Components.Tests.Infrastructure;

namespace ChainAsAService.Components.Tests
{
    public class HellorWorldHandlerTests
    {
        ///<summary>
        /// System under test
        ///</summary>
        private readonly HelloWorldHandler _sut = new HelloWorldHandler();

        [Fact]
        public void Process_HelloWorldOnConsoleExpected()
        {
            var currentConsoleOut = Console.Out;
            var expectedString = $"Hello world!{Environment.NewLine}";

            using (var fakeConsole = new FakeConsole())
            {
                _sut.Process();

                Assert.Equal(expectedString, fakeConsole.Output);
            }
        }
    }
}
