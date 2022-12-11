using BloggingPlatform.Models;
using BloggingPlatform.Models.SearchRequests;
using BloggingPlatform.Models.UpsertRequests;
using BloggingPlatform.Services;
using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.Controllers
{
    public class BlogPostController : BaseCRUDController<Models.BlogPost, BaseSearchRequest, BlogPostUpsert, BlogPostUpsert>
    {
        public BlogPostController(IBlogPostService service) : base(service)
        {
        }
    }
}
