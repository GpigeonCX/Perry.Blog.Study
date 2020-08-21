using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Perry.Blog.Domain;
using Volo.Abp;
using Volo.Abp.AspNetCore.MultiTenancy;
using Volo.Abp.Modularity;

namespace Perry.Blog.Swagger
{
    [DependsOn(
        typeof(PerryBlogDomainModule), 
        typeof(AbpAspNetCoreMultiTenancyModule)
    )]
    public class PerryBlogSwaggerModule :AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSwagger();
            context.Services.Configure<AbpAspNetCoreMultiTenancyOptions>(options =>
            {
                options.TenantKey = "MyTenantKey__tenant";
            });
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            app.UseMultiTenancy();

            context.GetApplicationBuilder().UseSwagger().UseSwaggerUI();
        }

    }
}
