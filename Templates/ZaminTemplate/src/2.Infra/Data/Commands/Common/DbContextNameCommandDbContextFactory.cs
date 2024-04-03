using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ZaminTemplate.Infra.Data.Sql.Commands.Common;

public class DbContextNameCommandDbContextFactory : IDesignTimeDbContextFactory<DbContextNameCommandDbContext>
{
    public DbContextNameCommandDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<DbContextNameCommandDbContext>();

        builder.UseSqlServer("Server =.; Database=DbContextNameDb;User Id = ;Password = ; MultipleActiveResultSets = true; Encrypt = false");

        return new DbContextNameCommandDbContext(builder.Options);
    }
}