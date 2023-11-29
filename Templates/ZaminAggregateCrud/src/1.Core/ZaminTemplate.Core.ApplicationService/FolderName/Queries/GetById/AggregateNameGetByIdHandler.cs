using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;
using ZaminTemplate.Core.Contracts.FolderName.Queries;
using ZaminTemplate.Core.RequestResponse.FolderName.Queries.GetById;

namespace ZaminTemplate.Core.ApplicationService.FolderName.Queries.GetById;

public sealed class AggregateNameGetByIdHandler : QueryHandler<AggregateNameGetByIdQuery, AggregateNameQr?>
{
    private readonly IAggregateNameQueryRepository _queryRepository;

    public AggregateNameGetByIdHandler(ZaminServices zaminServices, IAggregateNameQueryRepository queryRepository) 
        : base(zaminServices)
    {
        _queryRepository = queryRepository;
    }

    public override async Task<QueryResult<AggregateNameQr?>> Handle(AggregateNameGetByIdQuery query)
    {
        return Result(await _queryRepository.ExecuteAsync(query));
    }
}