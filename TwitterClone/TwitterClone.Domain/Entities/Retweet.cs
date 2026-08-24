namespace TwitterClone.Domain.Entities;

public class Retweet(string content) : BaseEntity
(Guid.NewGuid())
{
    public Retweet() : this(string.Empty) { }

    private Guid UserId { get; set; }
    private Guid TweetId { get; set; }

    public string Content { set; get; } = content;

    public override string DescribeRecord()
    {
        return $"{base.DescribeRecord()}\nRetweet: AuthorId: {UserId}, TweetId: {TweetId}, Content: {Content}";
    }
}