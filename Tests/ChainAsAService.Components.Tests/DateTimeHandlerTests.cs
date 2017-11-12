using System;
using Xunit;
using ChainAsAService.Components.Tests.Infrastructure;
using ChainAsAService.Core;

namespace ChainAsAService.Components.Tests
{
    public class DateTimeHandlerTests
    {
        ///<summary>
        /// System under test
        ///</summary>
        private readonly DateTimeHandler _sut;

        ///<summary>
        /// Fake DateTimeProvider which returns always the same date and time
        ///</summary>
        private readonly IDateTimeProvider _fakeDateTimeProvider = new FakeDateTimeProvider();

        public DateTimeHandlerTests()
        {
            _sut = new DateTimeHandler(_fakeDateTimeProvider);
        }

        [Fact]
        public void Process_HelloWorldOnConsoleExpected()
        {
            var currentConsoleOut = Console.Out;
            var expectedString = $"Current date and time: {_fakeDateTimeProvider.Now}{Environment.NewLine}";

            using (var fakeConsole = new FakeConsole())
            {
                _sut.Process();

                Assert.Equal(expectedString, fakeConsole.Output);
            }
        }
    }
}
