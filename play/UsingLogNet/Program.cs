using System;
using log4net;
using System.Reflection;
using log4net.Config;
using System.IO;

namespace UsingLogNet
{
    class Program
    {

        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            // Load configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("Log4net.config"));

            logger.Debug("this is a debug log ");
            logger.Error("this is  an error log");
            logger.Warn("this is a warning log");
            logger.Info("this is just for information");
            Console.WriteLine("Hello World!");
        }
    }
}
