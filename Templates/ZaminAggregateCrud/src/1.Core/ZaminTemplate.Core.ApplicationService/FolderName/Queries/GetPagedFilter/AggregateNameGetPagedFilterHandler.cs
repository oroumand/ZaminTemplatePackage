using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;
using ZaminTemplate.Core.Contracts.FolderName.Queries;
using ZaminTemplate.Core.RequestResponse.FolderName.Queries.GetPagedFilter;

namespace ZaminTemplate.Core.ApplicationService.FolderName.Queries.GetPagedFilter;

public sealed class AggregateNameGetPagedFilterHandler : QueryHandler<AggregateNameGetPagedFilterQuery, PagedData<AggregateNameListItemQr>>
{
    private readonly IAggregateNameQueryRepository _queryRepository;

    public AggregateNameGetPagedFilterHandler(ZaminServices zaminServices, IAggregateNameQueryRepository queryRepository) 
        : base(zaminServices)
    {
        _queryRepository = queryRepository;
    }

    public override async Task<QueryResult<PagedData<AggregateNameListItemQr>>> Handle(AggregateNameGetPagedFilterQuery query)
    {
        return Result(await _queryRepository.ExecuteAsync(query));
    }
}