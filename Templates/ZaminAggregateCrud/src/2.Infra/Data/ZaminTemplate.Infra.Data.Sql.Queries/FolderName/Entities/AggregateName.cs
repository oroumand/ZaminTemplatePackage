using ZaminTemplate.Core.RequestResponse.FolderName.Queries.GetById;
using ZaminTemplate.Core.RequestResponse.FolderName.Queries.GetPagedFilter;
using ZaminTemplate.Core.RequestResponse.FolderName.Queries.GetSelectList;

namespace ZaminTemplate.Infra.Data.Sql.Queries.FolderName.Entities;

public sealed class AggregateName
{
    public int Id { get; set; }
    public Guid BusinessId { get; set; }


    public static explicit operator AggregateNameQr(AggregateName entity) => new()
    {
        Id = entity.Id
    };

    public static explicit operator AggregateNameSelectItemQr(AggregateName entity) => new()
    {
        Id = entity.Id
    };

    public static explicit operator AggregateNameListItemQr(AggregateName entity) => new()
    {
        Id = entity.Id
    };
}
