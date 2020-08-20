using Perry.Blog.Domain.Blog;
using Perry.Blog.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Perry.Blog.EntityFrameworkCore.Repositories.Blog
{
    /// <summary>
    /// PostRepository
    /// </summary>
    public class PostRepository : EfCoreRepository<PerryBlogDbContext, Post, int>, IPostRepository
    {
        public PostRepository(IDbContextProvider<PerryBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
