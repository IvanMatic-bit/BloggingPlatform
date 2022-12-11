using BloggingPlatform.Models.SearchRequests;

namespace BloggingPlatform.Services
{
    public interface ITagService: ICRUDService<Models.Tag, BaseSearchRequest, Models.UpsertRequests.TagUpsert, Models.UpsertRequests.TagUpsert>
    {
    }
}
