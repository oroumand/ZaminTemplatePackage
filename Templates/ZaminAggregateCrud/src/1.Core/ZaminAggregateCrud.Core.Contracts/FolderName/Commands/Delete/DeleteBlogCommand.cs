using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace ZaminAggregateCrud.Core.Contracts.FolderName.Commands.Delete
{
    public sealed class DeleteBlogCommand : ICommand
    {
        public long BlogId { get; set; }
    }
}
