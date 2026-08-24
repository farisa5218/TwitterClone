using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public sealed class FriendRequestNotification : Notification
    {
        public FriendRequestNotification(Guid requestedByUserId) : base("friendRequest")
        {
            RequestedByUserId = requestedByUserId;
        }

        public Guid RequestedByUserId { get; set; }
        public void AddMessage(string message)
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            return $"{base.DescribeRecord()}\nFriendRequestNotification: RequestedByUserId: {RequestedByUserId}";
        }

        public override string GetMessage()
        {
            return $"User with ID {RequestedByUserId} sent you a friend request."; 
        }

    }
}
