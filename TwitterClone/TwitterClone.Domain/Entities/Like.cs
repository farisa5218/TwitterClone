namespace TwitterClone.Domain.Entities
{
    public class Like
    {
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public Guid TweetId { get; private set; }
        public DateTime LikedAt { get; private set; }

        public Like(Guid userId, Guid tweetId)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            TweetId = tweetId;
            LikedAt = DateTime.UtcNow;
        }
    }
}
