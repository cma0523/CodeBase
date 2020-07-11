using System;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.Extensions.Logging;

namespace NotificationConsumer
{
    public class NotificationConsumer : IConsumer<INotificationMessage>
    {
        private readonly ILogger _logger;
        private readonly IServiceProvider _serviceProvider;

        public NotificationConsumer(IServiceProvider serviceProvider, ILogger logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }


        public Task Consume(ConsumeContext<INotificationMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}
