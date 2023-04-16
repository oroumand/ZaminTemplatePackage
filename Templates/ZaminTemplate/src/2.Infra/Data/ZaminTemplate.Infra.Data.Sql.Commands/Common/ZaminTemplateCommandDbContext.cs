using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Zamin.Extensions.Events.Outbox.Dal.EF;
using Zamin.Infra.Data.Sql.Commands;
using ZaminTemplate.Core.Domain.Blogs.Entities;

namespace ZaminTemplate.Infra.Data.Sql.Commands.Common;

public class ZaminTemplateCommandDbContext : BaseOutboxCommandDbContext
{
    public DbSet<Blog> Blogs { get; set; }

    public ZaminTemplateCommandDbContext(DbContextOptions<ZaminTemplateCommandDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}
