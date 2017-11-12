using System;
using ChainAsAService.Core;

namespace ChainAsAService.Components
{
    public class DateTimeHandler : Handler
    {
        public DateTimeHandler(Handler successor) : base(successor)
        {
        }

        public override void Process()
        {
            throw new NotImplementedException();
        }
    }
}
