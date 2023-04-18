
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
    private readonly IBlogQueryRepository _queryRepository;

    public GetBlogDetailHandler(ZaminServices zaminServices,
                                  IBlogQueryRepository queryRepository) : base(zaminServices)
    {
        _queryRepository = queryRepository;
    }

    public override async Task<QueryResult<PagedData<BlogListItemQr>>> Handle(GetBlogPagedQuery query)
    {
        return Result(await _queryRepository.Execute(query));

    }
}

