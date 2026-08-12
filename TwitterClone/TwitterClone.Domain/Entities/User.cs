namespace TwitterClone.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }

        public User(string userName, string email)
        {
            Id = Guid.NewGuid();
            UserName = userName;
            Email = email;
        }
    }
}
