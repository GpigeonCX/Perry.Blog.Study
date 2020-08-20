using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Perry.Blog.Domain
{
    /// <summary>
    /// 
    /// </summary>
    [DependsOn(typeof(AbpIdentityDomainModule))] 
    public class PerryBlogDomainModule : AbpModule
    {
    }
}
