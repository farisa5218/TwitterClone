namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        public Guid Id { get; private set; }
        public Guid SenderId { get; private set; }
        public Guid ReceiverId { get; private set; }
        public string Content { get; private set; } = string.Empty;
        public DateTime SentAt { get; private set; }

        public Message(Guid senderId, Guid receiverId, string content)
        {
            if (senderId == receiverId)
                throw new ArgumentException("Sender and receiver cannot be the same.");

            Id = Guid.NewGuid();
            SenderId = senderId;
            ReceiverId = receiverId;

            SetContent(content);

            SentAt = DateTime.UtcNow;
        }
        public void SetContent(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Message cannot be empty.");

            Content = content;
        }
    }
}
