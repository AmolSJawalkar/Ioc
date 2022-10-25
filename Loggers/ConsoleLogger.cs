using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers
{
    public class ConsoleLogger : ILogger
    {
        public void WriteError(string message)
        {
           Console.WriteLine( "Error : " + message);
        }

        public void WriteInformation(string message)
        {
            Console.WriteLine("Information : " + message);
        }

        public void WriteWarning(string message)
        {
            Console.WriteLine("Warning : " + message);
        }
    }
}
