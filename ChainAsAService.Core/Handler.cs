using System;

namespace ChainAsAService.Core
{
    ///<summarize>
    /// Base class for all hanlders in solution
    ///</summarize>
    public abstract class Handler
    {
        ///<summarize>
        /// Successor of current handler
        ///</summarize>
        private readonly Handler _successor;

        ///<summary>
        /// Constructor with successor initializer
        ///</summary>
        public Handler(Handler successor)
        {
            _successor = successor;
        }

        ///<summary>
        /// Hanlder's main task
        ///</summary>
        public abstract void Process();

        ///<summary>
        /// Procced next element if exists
        ///</summary>
        protected void ProccedNext()
        {
            if (_successor != null)
            {
                _successor.Process();
            }
        }
    }
}
