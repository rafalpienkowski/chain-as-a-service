using System;
using ChainAsAService.Core;

namespace ChainAsAService.Components.Tests.Infrastructure
{
    ///<summary>
    /// Fake DateTime provider class used to assert agains console output
    ///</summary>
    public class FakeDateTimeProvider : IDateTimeProvider
    {
        ///<inheritdoc />
        DateTime IDateTimeProvider.Now => new DateTime(2017, 11, 12, 12, 23, 32);
    }
}
