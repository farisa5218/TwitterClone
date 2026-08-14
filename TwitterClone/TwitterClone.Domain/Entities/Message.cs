namespace TwitterClone.Domain.Entities;

public class Message : BaseEntity
{
    public Message() : this(string.Empty) { }

    public Message(string content) : base(Guid.NewGuid())
    {
        Content = content;
        SentAt = CreatedAt;
    }

    private Guid SenderId { get; set; }
    private Guid RecieverId { get; set; }
    private DateTime SentAt { get; set; }

    private string Content { set; get; }
    private bool IsRead { set; get; }

    public override string DescribeRecord()
    {
        return $"{base.DescribeRecord()}\nMessage: SenderId: {SenderId}, RecieverId: {RecieverId}, Content: {Content}, SentAt: {SentAt}, IsRead: {IsRead}";
    }
}