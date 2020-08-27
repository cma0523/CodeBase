using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncEngine.asyncs
{
    public class AsyncHelper
    {
        private int ThreadTest(int i)
        {
            Thread.Sleep(1000);
            Console.WriteLine("child thread starts");
            return i * 5;
        }

        private Task<string> ThreadTestV2()
        {
            var task = Task.Run(() =>
            {
                Thread.Sleep(3000);
                return "result";
            });

            return task;
        }

        #region Part2
        private void Producer()
        {
            var result = Process().Result;
        }

        private async Task Producer2()
        {
            await Process();
        }

        private async Task<bool> Process()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(1000);
            });

            Console.WriteLine("Ended - " + DateTime.Now.ToLongTimeString());
            return true;
        }
        #endregion
    }


}
