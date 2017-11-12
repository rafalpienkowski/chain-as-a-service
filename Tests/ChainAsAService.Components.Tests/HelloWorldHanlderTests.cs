using System;
using System.IO;
using Xunit;

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

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _sut.Process();

                Assert.Equal(expectedString, sw.ToString());
            }
        }
    }
}
