using System;
using System.IO;

namespace ChainAsAService.Components.Tests.Infrastructure
{
    ///<summary>
    /// Fake console class used to assert agains console output
    ///</summary>
    public class FakeConsole : IDisposable
    {
        private readonly StringWriter _stringWriter;

        ///<summary>
        /// Default constructor
        ///</summary>
        public FakeConsole()
        {
            _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
        }

        ///<summary>
        /// Gets console output for assert purposes
        ///</summary>
        public string Output 
        { 
            get => _stringWriter.ToString();
        }

        ///<summary>
        /// IDisposable interface implementation
        ///</summary>
        public void Dispose()
        {
            Console.SetOut(Console.Out);
            _stringWriter.Dispose();
        }
    }
}
