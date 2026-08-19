namespace TwitterClone.Domain.Entities;

public class User(string firstName, string lastName, string userName,
                  string email) : BaseEntity
(Guid.NewGuid())
{
    public User() :
        this(string.Empty, string.Empty, string.Empty, string.Empty){ }

    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public string UserName { get; set; } = userName;
    public string Email { get; set; } = email;

    public override string DescribeRecord()
    {
        return $"{base.DescribeRecord()}\nUser: FirstName: {FirstName}, LastName: {LastName}, UserName: {UserName}, Email: {Email}";
    }
}