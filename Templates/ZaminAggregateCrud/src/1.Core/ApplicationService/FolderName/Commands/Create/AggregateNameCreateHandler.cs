using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;
using ZaminTemplate.Core.Contracts.FolderName.Commands;
using ZaminTemplate.Core.Domain.FolderName.Entities;
using ZaminTemplate.Core.RequestResponse.FolderName.Commands.Create;

namespace ZaminTemplate.Core.ApplicationService.FolderName.Commands.Create;

public class AggregateNameCreateHandler : CommandHandler<AggregateNameCreateCommand, int>
{
    private readonly IAggregateNameCommandRepository _commandRepository;

    public AggregateNameCreateHandler(ZaminServices zaminServices, IAggregateNameCommandRepository commandRepository)
        : base(zaminServices)
    {
        _commandRepository = commandRepository;
    }

    public override async Task<CommandResult<int>> Handle(AggregateNameCreateCommand command)
    {
        AggregateName entity = new(command.ToParameter());

        await _commandRepository.InsertAsync(entity);

        await _commandRepository.CommitAsync();

        return await OkAsync(entity.Id);
    }
}