using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;

namespace ZaminTemplate.Infra.Data.Sql.Queries.Common
{
    public class ZaminTemplateQueryDbContext : BaseQueryDbContext
    {
        public ZaminTemplateQueryDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
