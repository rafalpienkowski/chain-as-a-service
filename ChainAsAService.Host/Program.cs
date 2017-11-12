using System;
using ChainAsAService.Host;
using ChainAsAService.Components;

namespace ChainAsAService.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create chain as a service
            var chain = new ServiceFactory().Create();

            // Start service
            chain.Process();
        }
    }
}
