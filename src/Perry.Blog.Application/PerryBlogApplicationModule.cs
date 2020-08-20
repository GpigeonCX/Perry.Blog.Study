using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Perry.Blog.Application
{
    [DependsOn(
        typeof(AbpIdentityApplicationModule)
    )]
    public class PerryBlogApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {

        }
    }
}
