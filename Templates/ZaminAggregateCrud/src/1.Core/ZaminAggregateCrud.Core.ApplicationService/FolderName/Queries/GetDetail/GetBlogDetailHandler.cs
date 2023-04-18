
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Utilities;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries.GetDetail;

namespace ZaminAggregateCrud.Core.ApplicationService.FolderName.Queries.GetDetail;

public sealed class GetBlogDetailHandler : QueryHandler<GetBlogByIdQuery, BlogDetailQr>
{
    private readonly IBlogQueryRepository _queryRepository;

    public GetBlogDetailHandler(ZaminServices zaminServices,
                                  IBlogQueryRepository queryRepository) : base(zaminServices)
    {
        _queryRepository = queryRepository;
    }

    public override async Task<QueryResult<BlogDetailQr>> Handle(GetBlogByIdQuery query)
    {
        return Result(await _queryRepository.Execute(query));
    }

}

