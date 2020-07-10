using System;
using System.Collections.Generic;
using System.Text;
using MassTransit;
using Microsoft.Extensions.Hosting;

namespace NotificationAgent
{
    public class BusService : IHostedService
    {
        private readonly IBusControl _busControl;

        public BusService(IBusControl busControl)
        {
            _busControl = busControl;


        }


    }
}
