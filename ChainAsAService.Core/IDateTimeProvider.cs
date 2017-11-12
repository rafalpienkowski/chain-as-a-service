using System;

namespace ChainAsAService.Core
{
    ///<summary>
    /// Date and time provider
    ///</summary>
    public interface IDateTimeProvider
    {
        ///<summary>
        /// Current DateTime
        ///</summary>
        DateTime Now { get; }
    }
}