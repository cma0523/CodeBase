using System;
using System.Threading.Tasks;
using NLog;

namespace NotificationAgent
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += ExceptionHandler;




        }


        private static void ExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            var logger = LogManager.LoadConfiguration("nlog.config").GetCurrentClassLogger();

            if (!(e.ExceptionObject is Exception exception))
            {
                exception = new NotSupportedException($"Unknown Exception: {e.ExceptionObject}");
            }

            logger.Error(exception, "something went wrong");
        }
    }
}
