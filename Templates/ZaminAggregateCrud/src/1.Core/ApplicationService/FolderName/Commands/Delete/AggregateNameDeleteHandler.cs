using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;
using ZaminTemplate.Core.Contracts.FolderName.Commands;
using ZaminTemplate.Core.Domain.FolderName.Entities;
using ZaminTemplate.Core.RequestResponse.FolderName.Commands.Delete;

namespace ZaminTemplate.Core.ApplicationService.FolderName.Commands.Delete;

public class AggregateNameDeleteHandler : CommandHandler<AggregateNameDeleteCommand>
{
    private readonly IAggregateNameCommandRepository _commandRepository;

    public AggregateNameDeleteHandler(ZaminServices zaminServices, IAggregateNameCommandRepository commandRepository)
        : base(zaminServices)
    {
        _commandRepository = commandRepository;
    }

    public override async Task<CommandResult> Handle(AggregateNameDeleteCommand command)
    {
        AggregateName entity = await _commandRepository.GetAsync(command.Id);

        if (entity is null)
        {
            throw new InvalidEntityStateException("VALIDATION_ERROR_NOT_EXIST", nameof(entity));
        }

        entity.Delete();

        _commandRepository.Delete(entity);

        await _commandRepository.CommitAsync();

        return Ok();
    }
}