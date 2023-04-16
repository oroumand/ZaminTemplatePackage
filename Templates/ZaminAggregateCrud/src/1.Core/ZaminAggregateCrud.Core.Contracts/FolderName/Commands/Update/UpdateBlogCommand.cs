using Zamin.Core.Contracts.ApplicationServices.Commands;
using ZaminAggregateCrud.Core.Domain.FolderName.Parameters;

namespace ZaminAggregateCrud.Core.Contracts.FolderName.Commands.Update
{
    public sealed class UpdateBlogCommand : ICommand
    {
        public long BlogId { get; set; }


        public BlogUpdateParameter ToParameter() => new BlogUpdateParameter();
    }
}
