using System.Numerics;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries.GetAll;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries.GetDetail;

namespace ZaminAggregateCrud.Infra.Data.Sql.Queries.FolderName.Entities
{
    internal sealed class Blog
    {
        public long Id{ get; set; }
        public Guid BusinessId { get; set; }


        public static explicit operator BlogListItemQr(Blog entity)=>
                new()
                {
                    Id = entity.Id
                };
        public static explicit operator BlogDetailQr(Blog entity) =>
        new()
        {
            Id = entity.Id
        };

    }
}
