using System;
using ChainAsAService.Core;

namespace ChainAsAService.Components
{
    ///<summary>
    /// Chain link which displays current date and time
    ///</summary>
    public class DateTimeHandler : Handler
    {
        private readonly IDateTimeProvider _dateTimeProvider = new SystemDateTimeProvider();

        ///<summary>
        /// Default constructor
        ///</summary>
        public DateTimeHandler() { }

        ///<summary>
        /// Constructor with IDateTimeProvider setup. 
        ///</summary>
        public DateTimeHandler(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        ///<inheritdoc />
        public override void Process()
        {
            Console.WriteLine($"Current date and time: {_dateTimeProvider.Now}");
            ProccedNext();
        }
    }
}
