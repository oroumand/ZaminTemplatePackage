using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries.GetAll;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries.GetPagedFilter;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries.GetDetail;
using ZaminAggregateCrud.Infra.Data.Sql.Queries.Common;
using ZaminAggregateCrud.Infra.Data.Sql.Queries.FolderName.Entities;
using Zamin.Core.Contracts.Data.Queries;

namespace ZaminAggregateCrud.Infra.Data.Sql.Queries.FolderName
{
    public class BlogQueryRepository : BaseQueryRepository<ZaminAggregateCrudQueryDbContext>, IBlogQueryRepository
    {
        public BlogQueryRepository(ZaminAggregateCrudQueryDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<BlogListItemQr>> Execute(GetAllBlogQuery query)
        {
            return await  _dbContext.Set<Blog>()
                .Select(q => (BlogListItemQr)q)
                .ToListAsync();
        }

        public async Task<PagedData<BlogListItemQr>> Execute(GetBlogPagedQuery query)
        {         
            var filter = _dbContext.Set<Blog>().AsQueryable();

            return await filter.ToPagedData(query,c=> (BlogListItemQr)c);
        }
        public async Task<BlogDetailQr> Execute(GetBlogByIdQuery query)
        {
            return await _dbContext.Set<Blog>()
                .Where(c => c.Id == query.BlogId)
                .Select(q => (BlogDetailQr)q)
                .FirstOrDefaultAsync();                
        }
    }
}