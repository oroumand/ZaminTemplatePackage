using Zamin.Core.RequestResponse.Commands;

namespace ZaminTemplate.Core.RequestResponse.FolderName.Commands.Delete;

public sealed class DeleteAggregateNameCommand : ICommand
{
    public int Id { get; set; }
}