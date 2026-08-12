namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        public Guid Id { get; private set; }
        public Guid FollowerId { get; private set; }
        public Guid FollowingId { get; private set; }
        public DateTime FollowedAt { get; private set; }

        public Follow(Guid followerId, Guid followingId)
        {
            if (followerId == followingId)
                throw new ArgumentException("A user cannot follow themselves.");

            Id = Guid.NewGuid();
            FollowerId = followerId;
            FollowingId = followingId;
            FollowedAt = DateTime.UtcNow;
        }
    }
}
