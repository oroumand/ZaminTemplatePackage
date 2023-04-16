using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace ZaminAggregateCrud.Core.Contracts.FolderName.Commands.Create
{
    public sealed class CreateBlogCommand : ICommand
    {
        public Guid BusunessId { get; set; }
    }
}
