using System;

namespace ChainAsAService.Core
{
    ///<summary>
    /// DateTime provider from system DateTime class
    ///</summary>
    public class SystemDateTimeProvider : IDateTimeProvider
    {
        ///<inheritdoc />
        DateTime IDateTimeProvider.Now => DateTime.Now;
    }
}