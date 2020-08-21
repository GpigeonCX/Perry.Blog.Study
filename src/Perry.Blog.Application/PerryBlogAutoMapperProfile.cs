using AutoMapper;
using Perry.Blog.Application.Contracts.Blog;
using Perry.Blog.Domain.Blog;

namespace Perry.Blog.Application
{
    public class PerryBlogAutoMapperProfile : Profile
    {
        public PerryBlogAutoMapperProfile()
        {
            CreateMap<Post, PostDto>();

            CreateMap<PostDto, Post>().ForMember(x => x.Id, opt => opt.Ignore());
        }
    }
}
