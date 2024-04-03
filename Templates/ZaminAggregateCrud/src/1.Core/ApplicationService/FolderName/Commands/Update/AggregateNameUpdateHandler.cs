using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;
using ZaminTemplate.Core.Contracts.FolderName.Commands;
using ZaminTemplate.Core.Domain.FolderName.Entities;
using ZaminTemplate.Core.RequestResponse.FolderName.Commands.Update;

namespace ZaminTemplate.Core.ApplicationService.FolderName.Commands.Update;

public class AggregateNameUpdateHandler : CommandHandler<AggregateNameUpdateCommand>
{
    private readonly IAggregateNameCommandRepository _commandRepository;

    public AggregateNameUpdateHandler(ZaminServices zaminServices, IAggregateNameCommandRepository commandRepository)
        : base(zaminServices)
    {
        _commandRepository = commandRepository;
    }

    public override async Task<CommandResult> Handle(AggregateNameUpdateCommand command)
    {
        AggregateName entity = await _commandRepository.GetAsync(command.Id);

        if (entity is null)
        {
            throw new InvalidEntityStateException("VALIDATION_ERROR_NOT_EXIST", nameof(entity));
        }

        entity.Update(command.ToParameter());

        await _commandRepository.CommitAsync();

        return Ok();
    }
}