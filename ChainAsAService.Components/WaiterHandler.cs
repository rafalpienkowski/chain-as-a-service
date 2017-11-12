using System;
using ChainAsAService.Core;

namespace ChainAsAService.Components
{
    public class WaiterHandler : Handler
    {
        public WaiterHandler(Handler successor) : base(successor)
        {
        }

        public override void Process()
        {
            throw new NotImplementedException();
        }
    }
}
