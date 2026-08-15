namespace TwitterClone.Domain.Entities;

public class Follow : BaseEntity
{
    public Follow() : base(Guid.NewGuid()) { }

    private Guid FollowingId { get; }
    private Guid FollowerId { get; }

    public override string DescribeRecord()
    {
        return $"{base.DescribeRecord()}\nFollow: FollowingId: {FollowingId}, FollowerId: {FollowerId}, FollowedAt: {CreatedAt}";
    }
}