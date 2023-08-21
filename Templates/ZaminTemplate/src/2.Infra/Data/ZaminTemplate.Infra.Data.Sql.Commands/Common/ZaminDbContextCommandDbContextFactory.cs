using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ZaminTemplate.Infra.Data.Sql.Commands.Common;

public class ZaminDbContextCommandDbContextFactory : IDesignTimeDbContextFactory<ZaminDbContextCommandDbContext>
{
    public ZaminDbContextCommandDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<ZaminDbContextCommandDbContext>();

        builder.UseSqlServer("Server =.; Database=ZaminTemplateDb;User Id = ;Password = ; MultipleActiveResultSets = true; Encrypt = false");

        return new ZaminDbContextCommandDbContext(builder.Options);
    }
}