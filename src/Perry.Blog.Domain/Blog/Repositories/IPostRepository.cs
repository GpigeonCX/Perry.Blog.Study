using Perry.Blog.Domain.Blog;
using Volo.Abp.Domain.Repositories;

namespace Perry.Blog.Domain.Repositories
{
    /// <summary>
    /// IPostRepository
    /// </summary>
    public interface IPostRepository : IRepository<Post, int>
    {
    }
}
