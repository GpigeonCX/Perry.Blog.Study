using Perry.Blog.Application.Caching;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Perry.Blog.Application
{
    [DependsOn(
        typeof(AbpIdentityApplicationModule)
        , typeof(AbpAutoMapperModule)
        //, typeof(PerryBlogApplicationCachingModule)
    )]
    public class PerryBlogApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<PerryBlogApplicationModule>(validate: true);
                options.AddProfile<PerryBlogAutoMapperProfile>(validate: true);
            });
        }
    }
}
