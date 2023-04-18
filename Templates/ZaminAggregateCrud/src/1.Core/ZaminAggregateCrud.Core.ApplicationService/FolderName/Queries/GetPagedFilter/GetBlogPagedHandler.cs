
using Zamin.Core.ApplicationServices.Queries;

using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Utilities;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries.GetAll;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries.GetPagedFilter;

namespace ZaminAggregateCrud.Core.ApplicationService.FolderName.Queries.GetPagedFilter;

public sealed class GetBlogDetailHandler : QueryHandler<GetBlogPagedQuery, PagedData<BlogListItemQr>>
{
    private readonly IBlogQueryRepository _blogQueryRepository;

    public GetBlogDetailHandler(ZaminServices zaminServices,
                                  IBlogQueryRepository blogQueryRepository) : base(zaminServices)
    {
        _blogQueryRepository = blogQueryRepository;
    }

    public override async Task<QueryResult<PagedData<BlogListItemQr>>> Handle(GetBlogPagedQuery query)
    {
        return Result(await _blogQueryRepository.Execute(query));

    }
}

