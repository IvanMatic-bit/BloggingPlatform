using BloggingPlatform.Models;
using BloggingPlatform.Models.SearchRequests;
using BloggingPlatform.Models.UpsertRequests;
using BloggingPlatform.Services;
using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.Controllers
{
    public class CommentController : BaseCRUDController<Comment, BaseSearchRequest, CommentUpsert, CommentUpsert>
    {
        public CommentController(ICommentService service) : base(service)
        {
        }
    }
}
