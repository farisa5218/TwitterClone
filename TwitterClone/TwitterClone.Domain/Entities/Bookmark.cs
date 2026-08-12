using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Bookmark
    {
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public Guid TweetId { get; private set; }
        public DateTime BookmarkedAt { get; private set; }

        public Bookmark(Guid userId, Guid tweetId)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            TweetId = tweetId;
            BookmarkedAt = DateTime.UtcNow;
        }
    }
}
