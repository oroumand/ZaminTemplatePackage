using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;

namespace ZaminTemplate.Infra.Data.Sql.Queries.Common;

public class ZaminDbContextQueryDbContext : BaseQueryDbContext
{
    public ZaminDbContextQueryDbContext(DbContextOptions<ZaminDbContextQueryDbContext> options) : base(options)
    {
    }
}