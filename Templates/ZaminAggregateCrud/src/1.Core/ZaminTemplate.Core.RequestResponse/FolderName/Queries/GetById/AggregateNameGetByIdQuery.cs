using Zamin.Core.RequestResponse.Queries;

namespace ZaminTemplate.Core.RequestResponse.FolderName.Queries.GetById;

public sealed class AggregateNameGetByIdQuery : IQuery<AggregateNameQr?>
{
    public int Id { get; set; }
}