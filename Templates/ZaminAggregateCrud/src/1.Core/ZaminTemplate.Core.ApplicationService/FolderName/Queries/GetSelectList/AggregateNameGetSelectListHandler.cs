using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;
using ZaminTemplate.Core.Contracts.FolderName.Queries;
using ZaminTemplate.Core.RequestResponse.FolderName.Queries.GetSelectList;

namespace ZaminTemplate.Core.ApplicationService.FolderName.Queries.GetSelectList;

public sealed class AggregateNameGetSelectListHandler : QueryHandler<AggregateNameGetSelectListQuery, List<AggregateNameSelectItemQr>>
{
    private readonly IAggregateNameQueryRepository _queryRepository;

    public AggregateNameGetSelectListHandler(ZaminServices zaminServices, IAggregateNameQueryRepository queryRepository) 
        : base(zaminServices)
    {
        _queryRepository = queryRepository;
    }

    public override async Task<QueryResult<List<AggregateNameSelectItemQr>>> Handle(AggregateNameGetSelectListQuery query)
    {
        return Result(await _queryRepository.ExecuteAsync(query));
    }
}