using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public sealed class SystemNotification : Notification
    {
        public SystemNotification():base("system")
        {

        }

        public void AddMessage(string message)
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            return base.DescribeRecord();
        }

        public override string GetMessage()
        {
            return $"System Notification: {Message}";
        }
    }
}
