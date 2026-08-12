namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        public Guid Id { get; private set; }
        public Guid AuthorId { get; private set; }
        public string Content { get; private set; } = string.Empty;

        public Tweet(Guid authorId, string content)
        {
            Id = Guid.NewGuid();
            AuthorId = authorId;
            SetContent(content);
        }

        private void SetContent(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Tweet cannot be empty.");
            if (content.Length > 280)
                throw new ArgumentException("Tweet cannot exceed 280 characters.");

            Content = content;
        }
    }
}
