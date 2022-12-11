using System;
using System.Collections.Generic;

namespace BloggingPlatform.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public int BlogPostId { get; set; }
    }
}
