using AutoMapper;
using BloggingPlatform.Database;
using BloggingPlatform.Models;
using BloggingPlatform.Models.SearchRequests;
using BloggingPlatform.Models.UpsertRequests;

namespace BloggingPlatform.Services
{
    public class TagService : BaseCRUDService<Models.Tag, BaseSearchRequest, Database.Tag, TagUpsert, TagUpsert>, ITagService
    {
        public TagService(BloggingPlatformContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
