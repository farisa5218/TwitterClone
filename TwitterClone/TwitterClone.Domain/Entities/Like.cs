namespace TwitterClone.Domain.Entities;

public class Like : BaseEntity
{
    public Like() : base(Guid.NewGuid()) { }

    public Guid TweetId { get; }

    public override string DescribeRecord()
    {
        return $"{base.DescribeRecord()}\nLike: TweetId: {TweetId}";
    }
}