using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Infra.Data.Sql.Queries;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries;
using ZaminAggregateCrud.Infra.Data.Sql.Queries.Common;

namespace ZaminAggregateCrud.Infra.Data.Sql.Queries.FolderName
{
    public class BlogQueryRepository : BaseQueryRepository<ZaminAggregateCrudQueryDbContext>, IBlogQueryRepository
    {
        public BlogQueryRepository(ZaminAggregateCrudQueryDbContext dbContext) : base(dbContext)
        {
        }
    }
}
