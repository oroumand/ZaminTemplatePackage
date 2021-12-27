using Microsoft.EntityFrameworkCore;
using ZaminTemplate.Core.Domain.Blogs.Entities;
using Zamin.Core.Domain.Toolkits.ValueObjects;
using Zamin.Infra.Data.Sql.Commands;

namespace ZaminTemplate.Infra.Data.Sql.Commands.Common
{
    public class ZaminTemplateCommandDbContext : BaseCommandDbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public ZaminTemplateCommandDbContext(DbContextOptions<ZaminTemplateCommandDbContext> options) : base(options)
        {
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {

            configurationBuilder.Properties<Description>().HaveConversion<DescriptionConversion>();
            configurationBuilder.Properties<Title>().HaveConversion<TitleConversion>();
        }
    }
}
