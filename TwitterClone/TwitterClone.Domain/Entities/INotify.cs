using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public interface INotify
    {
        void AddNotification(Guid notificationId);
    }
}
