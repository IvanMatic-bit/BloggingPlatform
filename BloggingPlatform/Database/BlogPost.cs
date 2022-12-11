using System;


namespace BloggingPlatform.Database
{
    public partial class BlogPost
    {
        public BlogPost()
        {

        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public int TagId { get; set; }

        public virtual Tag Tag { get; set; }
    }
}

