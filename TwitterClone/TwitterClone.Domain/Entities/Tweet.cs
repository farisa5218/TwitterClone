namespace TwitterClone.Domain.Entities;

public class Tweet : BaseEntity, Ilikeable
{
    private Guid _userId {  get; set; }
    private string _content { get; set; } = string.Empty;

    public Tweet (string content) :base(Guid.NewGuid())
    {
        _content = content;
    }

    public static int MaxContentLength = 250;

    public void AddContent(Guid userId,string content)
    {
        _userId = userId;
        _content = content;
    }

    public override string DescribeRecord()
    {
        var baseRecord = base.DescribeRecord();
        return $"{baseRecord} | UserId: {_userId} | Content: {_content}"; 
    }

    public bool CanBeLiked()
    {
        if(string.IsNullOrWhiteSpace(_content))
        {
            return false;
        }
        return true;
    }
}