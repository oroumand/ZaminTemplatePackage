using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ZaminTemplate.Infra.Data.Sql.Commands.Common;

public class ZaminTemplateCommandDbContextFactory : IDesignTimeDbContextFactory<ZaminTemplateCommandDbContext>
{
    public ZaminTemplateCommandDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<ZaminTemplateCommandDbContext>();

        builder.UseSqlServer("Server =.; Database=ZaminTemplateDb;User Id = ;Password = ; MultipleActiveResultSets = true; Encrypt = false");

        return new ZaminTemplateCommandDbContext(builder.Options);
    }
}