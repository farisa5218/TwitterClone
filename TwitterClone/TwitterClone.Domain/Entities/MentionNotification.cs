using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public sealed class MentionNotification : Notification
    {
        public MentionNotification(Guid mentionByUserId): base("Mention")
        {
            MentionByUserId = mentionByUserId;
        }
        public Guid MentionByUserId { get; set; }

        public override string DescribeRecord()
        {
            return $"{base.DescribeRecord()}\nMentionNotification: MentionByUserId: {MentionByUserId}";
        }

        public override string GetMessage()
        {
            return $"User with ID {MentionByUserId} mentioned you in a post.";
        }
    }
}
