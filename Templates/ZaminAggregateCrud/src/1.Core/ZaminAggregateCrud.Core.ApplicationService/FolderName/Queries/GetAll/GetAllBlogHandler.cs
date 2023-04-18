
using Zamin.Core.ApplicationServices.Queries;

using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Utilities;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries.GetAll;

namespace ZaminAggregateCrud.Core.ApplicationService.FolderName.Queries.GetAll;

public sealed class GetAllBlogHandler : QueryHandler<GetAllBlogQuery, List<BlogListItemQr>>
{
    private readonly IBlogQueryRepository _queryRepository;

    public GetAllBlogHandler(ZaminServices zaminServices,
                                  IBlogQueryRepository queryRepository) : base(zaminServices)
    {
        _queryRepository = queryRepository;
    }

    public override async Task<QueryResult<List<BlogListItemQr>>> Handle(GetAllBlogQuery query)
    {
        return Result(await _queryRepository.Execute(entity));
    }
}

