using Perry.Blog.Domain;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;

namespace Perry.Blog.Application.Caching
{
    [DependsOn(
    typeof(AbpCachingModule),
    typeof(PerryBlogDomainModule)
    )]
    public class PerryBlogApplicationCachingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }
    }
}
