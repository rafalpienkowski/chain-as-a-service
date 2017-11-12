using System;
using Xunit;
using ChainAsAService.Components;
using System.Diagnostics;

namespace ChainAsAService.Components.Tests
{
    public class WaiterHandlerTests
    {
        ///<summary>
        /// System under test
        ///</summary>
        private readonly WaiterHandler _sut = new WaiterHandler();

        [Fact]
        public void Proccess_ThreadShouldWaitAtLeastOneSecond()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            _sut.Process();
            stopWatch.Stop();

            var timespan = stopWatch.Elapsed;
            Assert.Equal(1, timespan.Seconds);
        }
    }
}
