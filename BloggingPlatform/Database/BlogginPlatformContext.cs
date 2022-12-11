using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BloggingPlatform.Database
{
    public partial class BloggingPlatformContext: DbContext
    {
        public BloggingPlatformContext() { }

        public BloggingPlatformContext(DbContextOptions<BloggingPlatformContext> options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost, 1434;Initial Catalog=BloggingPLatform; user=sa; Password=QWEasd123!");
            }
        }

        public virtual DbSet<BlogPost> Blogposts { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}