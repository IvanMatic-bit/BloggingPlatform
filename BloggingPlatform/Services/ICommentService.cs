using BloggingPlatform.Models.SearchRequests;

namespace BloggingPlatform.Services
{
    public interface ICommentService: ICRUDService<Models.Comment, BaseSearchRequest, Models.UpsertRequests.CommentUpsert, Models.UpsertRequests.CommentUpsert>
    {
    }
}
