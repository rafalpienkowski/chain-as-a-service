using System;
using ChainAsAService.Core;
using System.Threading;

namespace ChainAsAService.Components
{
    ///<summary>
    /// Waiter chain link. Sleeps threar for a 1 second
    ///</summary>
    public class WaiterHandler : Handler
    {
        ///<inheritdoc />
        public override void Process()
        {
            Thread.Sleep(1000);
            ProccedNext();
        }
    }
}
