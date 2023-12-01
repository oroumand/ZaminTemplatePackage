using Zamin.Core.RequestResponse.Commands;

namespace ZaminTemplate.Core.RequestResponse.FolderName.Commands.Delete;

public sealed class AggregateNameDeleteCommand : ICommand
{
    public int Id { get; set; }
}