using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Perry.Blog.Domain.Shared
{
    [DependsOn(typeof(AbpIdentityDomainSharedModule))]
    //[DependsOn(typeof(AbpIdentityDomainModule))]
    public class PerryBlogDomainSharedModule : AbpModule
    {
    }
}
