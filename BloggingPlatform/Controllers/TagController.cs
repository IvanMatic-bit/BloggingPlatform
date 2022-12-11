using BloggingPlatform.Models;
using BloggingPlatform.Models.SearchRequests;
using BloggingPlatform.Models.UpsertRequests;
using BloggingPlatform.Services;
using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.Controllers
{
    public class TagController : BaseCRUDController<Models.Tag, BaseSearchRequest, TagUpsert, TagUpsert>
    {
        public TagController(ITagService service) : base(service)
        {
        }
    }
}
