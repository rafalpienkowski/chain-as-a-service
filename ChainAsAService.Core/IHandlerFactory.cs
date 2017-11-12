using System;

namespace ChainAsAService.Core
{
    ///<summary>
    /// Factory interface
    ///</summary>
    public interface IHandlerFactory
    {
        ///<summary>
        /// Create chain
        ///</summary>
        Handler Create();
    }
}