using Zamin.Core.Contracts.ApplicationServices.Queries;

namespace ZaminAggregateCrud.Core.Contracts.FolderName.Queries.GetDetail
{
    public sealed class GetBlogByIdQuery : IQuery<BlogDetailQr>
    {
        public long BlogId { get; set; }
    }
}
