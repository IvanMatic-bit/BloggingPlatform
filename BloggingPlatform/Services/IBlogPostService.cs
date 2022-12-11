using BloggingPlatform.Models.SearchRequests;

namespace BloggingPlatform.Services
{
    public interface IBlogPostService: ICRUDService<Models.BlogPost, BaseSearchRequest, Models.UpsertRequests.BlogPostUpsert, Models.UpsertRequests.BlogPostUpsert>
    {
    }
}
