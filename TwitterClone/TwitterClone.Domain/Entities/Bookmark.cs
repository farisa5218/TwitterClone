namespace TwitterClone.Domain.Entities;

public class Bookmark : BaseEntity
{
    public Bookmark() : base(Guid.NewGuid()) { }

    private Guid TweetId { get; set; }
    private Guid UserId { get; set; }

    public override string DescribeRecord()
    {
        return $"{base.DescribeRecord()}\nBookmark: TweetId: {TweetId}, UserId: {UserId}, CreatedAt: {CreatedAt}";
    }
}