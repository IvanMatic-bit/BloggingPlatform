using AutoMapper;
using BloggingPlatform.Database;
using BloggingPlatform.Models.SearchRequests;
using BloggingPlatform.Models.UpsertRequests;

namespace BloggingPlatform.Services
{
    public class CommentService : BaseCRUDService<Models.Comment, BaseSearchRequest, Database.Comment, CommentUpsert, CommentUpsert>, ICommentService
    {
        public CommentService(BloggingPlatformContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
