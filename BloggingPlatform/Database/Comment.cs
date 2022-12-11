using System;


namespace BloggingPlatform.Database
{
    public class Comment
    {
        public Comment()
        {
        }

        public int Id { get; set; }
        public string Body { get; set; }
        public int BlogPostId { get; set; }

        public virtual BlogPost BlogPost { get; set; }
    }
}

