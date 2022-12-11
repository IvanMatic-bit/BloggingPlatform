namespace BloggingPlatform.Models.UpsertRequests
{
    public class CommentUpsert
    {
        public string Body { get; set; }
        public int BlogPostId { get; set; }
    }
}
