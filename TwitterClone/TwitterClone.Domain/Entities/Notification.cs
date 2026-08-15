namespace TwitterClone.Domain.Entities;

public class Notification(string content, NotificationType type) : BaseEntity
(Guid.NewGuid())
{
    private Guid UserId { get; set; }
    private NotificationType Type { get; } = type;
    private string Content { set; get; } = content;
    private bool IsRead { get; set; } = false;

    public override string DescribeRecord()
    {
        return $"{base.DescribeRecord()}\nNotification: UserId: {UserId}, Type: {Type}, Content: {Content}, IsRead: {IsRead}";
    }
}