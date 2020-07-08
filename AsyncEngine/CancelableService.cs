using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncEngine
{
    internal class CancelableService
    {

        internal int CancelableMethod(CancellationToken cancellationToken)
        {
            for (int i = 0; i < 100; ++i)
            {
                Thread.Sleep(1000);
                cancellationToken.ThrowIfCancellationRequested();
            }

            return 50;
        }

        async Task IssueTimeoutAsync()
        {
            var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
            var token = cts.Token;
            await Task.Delay(TimeSpan.FromSeconds(10), token);

        }


    }
}
