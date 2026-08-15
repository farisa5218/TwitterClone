namespace TwitterClone.Domain.Entities;

public sealed class CommentNotification(Guid commentByUserId) : Notification ("Comment", NotificationType.Comment)
{
    public Guid CommentByUserId { get; set; } = commentByUserId;
    public string Message { get; set; } = string.Empty;

    public void AddMessage(string message)
    {
        Message = message;
    }

    public override string DescribeRecord()
    {
        return $"{base.DescribeRecord()}\nCommentNotification: CommentByUserId: {CommentByUserId}, Message: {Message}";
    }
}