using Ioc;
using Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var container = BootStrap();
            var logger = container.Resolve<ILogger>();

            logger.WriteInformation("First message using Ioc");
        }


        private static Container BootStrap()
        {
            var iocContainer = new Container();
            iocContainer.Register<ILogger, ConsoleLogger>();
            return iocContainer;
        }
    }
}
