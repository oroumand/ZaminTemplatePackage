using ZaminAggregateCrud.Core.Contracts.FolderName.Queries.GetAll;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries.GetPagedFilter;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries.GetDetail;
using Zamin.Core.Contracts.Data.Queries;

namespace ZaminAggregateCrud.Core.Contracts.FolderName.Queries
{
    public interface IBlogQueryRepository
    {
        Task<List<BlogListItemQr>> Execute(GetAllBlogQuery query);
        Task<PagedData<BlogListItemQr>> Execute(GetBlogPagedQuery query);
        Task<BlogDetailQr> Execute(GetBlogByIdQuery query);
    }
}
