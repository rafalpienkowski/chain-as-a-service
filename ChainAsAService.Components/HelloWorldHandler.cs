using System;
using ChainAsAService.Core;

namespace ChainAsAService.Components
{
    ///<summary>
    /// Hello world chain link
    ///</summary>
    public class HelloWorldHandler : Handler
    {
        ///<inheritdoc />
        public override void Process()
        {
            Console.WriteLine("Hello world!");
            ProccedNext();
        }
    }
}
