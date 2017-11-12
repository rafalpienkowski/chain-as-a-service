using System;
using ChainAsAService.Core;

namespace ChainAsAService.Components
{
    public class HelloWorldHandler : Handler
    {
        public HelloWorldHandler(Handler successor) : base(successor)
        {
        }

        public override void Process()
        {
            throw new NotImplementedException();
        }
    }
}
