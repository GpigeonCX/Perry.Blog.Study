using Perry.Blog.Application;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Perry.Blog.HttpApi
{
    [DependsOn(
      typeof(AbpIdentityHttpApiModule)
    )]
    [DependsOn(typeof(PerryBlogApplicationModule))]
    public class PerryBlogHttpApiModule : AbpModule
    {

    }
}
