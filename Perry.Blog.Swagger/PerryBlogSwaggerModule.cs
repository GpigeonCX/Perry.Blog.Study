using Microsoft.AspNetCore.Builder;
using Perry.Blog.Domain;
using Volo.Abp;
using Volo.Abp.Modularity;

namespace Perry.Blog.Swagger
{
    [DependsOn(typeof(PerryBlogDomainModule))]
    public class PerryBlogSwaggerModule :AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSwagger();
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            context.GetApplicationBuilder().UseSwagger().UseSwaggerUI();
        }
    }
}
