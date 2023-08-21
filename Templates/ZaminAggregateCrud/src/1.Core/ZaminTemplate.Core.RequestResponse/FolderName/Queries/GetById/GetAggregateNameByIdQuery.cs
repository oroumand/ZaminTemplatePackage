using Zamin.Core.RequestResponse.Queries;

namespace ZaminTemplate.Core.RequestResponse.FolderName.Queries.GetById;

public sealed class GetAggregateNameByIdQuery : IQuery<AggregateNameQr?>
{
    public int Id { get; set; }
}