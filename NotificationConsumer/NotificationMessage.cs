using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationConsumer
{
    public interface INotificationMessage
    {
        string UserName { get; set;}

        string Message { get; set; }

        Guid Id { get; set; }

        DateTime QueueOnTime { get; set; }

    }
}
