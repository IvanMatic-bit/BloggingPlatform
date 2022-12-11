using System;
using System.Collections.Generic;

namespace BloggingPlatform.Models
{
    public partial class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
    }
}
