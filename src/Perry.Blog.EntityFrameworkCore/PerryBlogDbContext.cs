using Microsoft.EntityFrameworkCore;
using Perry.Blog.Domain.Blog;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Perry.Blog.EntityFrameworkCore
{
    [ConnectionStringName("MySql")]
    public class PerryBlogDbContext : AbpDbContext<PerryBlogDbContext>
    {
        public DbSet<Post> Posts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<PostTag> PostTags { get; set; }

        public DbSet<FriendLink> FriendLinks { get; set; }


        public PerryBlogDbContext(DbContextOptions<PerryBlogDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configure();
        }
    }
}
