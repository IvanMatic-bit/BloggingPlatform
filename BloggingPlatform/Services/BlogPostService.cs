using AutoMapper;
using BloggingPlatform.Database;
using BloggingPlatform.Models.SearchRequests;
using BloggingPlatform.Models.UpsertRequests;

namespace BloggingPlatform.Services
{
    public class BlogPostService : BaseCRUDService<Models.BlogPost, BaseSearchRequest, Database.BlogPost, Models.UpsertRequests.BlogPostUpsert, Models.UpsertRequests.BlogPostUpsert>, IBlogPostService
    {
        public BlogPostService(BloggingPlatformContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
