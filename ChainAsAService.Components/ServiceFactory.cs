using System;
using ChainAsAService.Core;

namespace ChainAsAService.Components
{
    public class ServiceFactory : IHandlerFactory
    {
        ///<inheritdoc />
        public Handler Create()
        {
            // I'm creating my chain links
            var helloWorldHanlder = new HelloWorldHandler();
            var dateTimeHandler = new DateTimeHandler();
            var firstWaitHandler = new WaiterHandler();
            var secondWaitHandler = new WaiterHandler();                    
            
            // Successors setup
            helloWorldHanlder.SetSuccessor(firstWaitHandler);
            firstWaitHandler.SetSuccessor(dateTimeHandler);
            dateTimeHandler.SetSuccessor(secondWaitHandler);
            secondWaitHandler.SetSuccessor(helloWorldHanlder);

            // returns first element in chain
            return helloWorldHanlder;
        }
    }
}
