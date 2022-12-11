using AutoMapper;
using BloggingPlatform.Models.UpsertRequests;

namespace BloggingPlatform.Mapper
{
	public class Mapper: Profile
	{
		public Mapper() { 
			CreateMap<Database.BlogPost, Models.BlogPost>();
			CreateMap<Database.Comment, Models.Comment>();
			CreateMap<Database.Tag, Models.Tag>();

			CreateMap<BlogPostUpsert, Database.BlogPost>();
			CreateMap<TagUpsert, Database.Tag>();
			CreateMap<CommentUpsert, Database.Comment>();
		}
	}
}