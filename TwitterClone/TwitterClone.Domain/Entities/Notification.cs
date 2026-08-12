namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public string Message { get; private set; }
        public bool IsRead { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Notification(Guid userId, string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException("Notification message cannot be empty.");

            Id = Guid.NewGuid();
            UserId = userId;
            Message = message;
            CreatedAt = DateTime.UtcNow;
            IsRead = false;
        }
        public void MarkAsRead()
        {
            IsRead = true;
        }
    }
}
