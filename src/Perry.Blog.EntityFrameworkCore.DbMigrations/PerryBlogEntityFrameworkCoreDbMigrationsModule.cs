using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Perry.Blog.EntityFrameworkCore.DbMigrations
{
    [DependsOn(typeof(PerryBlogFrameworkCoreModule)
        )]
    public class PerryBlogEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<PerryBlogMigrationsDbContext>();
        }
    }
}
