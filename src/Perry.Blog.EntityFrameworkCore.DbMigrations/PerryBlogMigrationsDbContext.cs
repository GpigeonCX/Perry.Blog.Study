using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Perry.Blog.EntityFrameworkCore.DbMigrations
{
    public class PerryBlogMigrationsDbContext : AbpDbContext<PerryBlogMigrationsDbContext>
    {
        public PerryBlogMigrationsDbContext(DbContextOptions<PerryBlogMigrationsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Configure();
        }
    }
}
