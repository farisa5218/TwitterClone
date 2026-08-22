namespace TwitterClone.Domain.Entities;

public class User: BaseEntity,IFollowable, INotify
{

    public User() : base(Guid.NewGuid())
    {

    }
    private string Username { get;  set; } = string.Empty;
    private string Email { get; set; } = string.Empty;
    private string PasswordHash { get; set; }= string.Empty;

    private string _firstName { get; set; } = string.Empty;
    private string _lastName { get; set; } = string.Empty;
    private string _email { get; set; } = string.Empty;

    public override string DescribeRecord()
    {
        var baseRecord = base.DescribeRecord();
        return $"{baseRecord}, FirstName: {_firstName}, LastName: {_lastName}, Email: {_email}";
    }

    private List<Guid> _followers = new List<Guid>();
    private List<Guid> _inComingNotifications = new List<Guid>();
    public void Follow(Guid userId)
    {
        if (!_followers.Contains(userId))
        {
            _followers.Add(userId);
        }
    }
    public void Unfollow(Guid userId)
    {
        if (_followers.Contains(userId))
        {
            _followers.Remove(userId);
        }
    }
    public void AddNotification(Guid notificationId)
    {
        if (!_inComingNotifications.Contains(notificationId))
        {
            _inComingNotifications.Add(notificationId);
        }
    }
}