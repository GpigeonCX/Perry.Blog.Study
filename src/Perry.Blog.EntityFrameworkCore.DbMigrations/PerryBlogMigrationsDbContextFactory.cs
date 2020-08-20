using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Perry.Blog.EntityFrameworkCore.DbMigrations
{
    public class PerryBlogMigrationsDbContextFactory : IDesignTimeDbContextFactory<PerryBlogMigrationsDbContext>
    {
        public PerryBlogMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<PerryBlogMigrationsDbContext>()
                .UseMySql(configuration.GetConnectionString("Default"));

            return new PerryBlogMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
    }
}
