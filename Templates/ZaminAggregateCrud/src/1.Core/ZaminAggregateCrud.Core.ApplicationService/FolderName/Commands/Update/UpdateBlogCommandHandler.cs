using System.Xml.Linq;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Core.Contracts.Data.Commands;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Exceptions;
using Zamin.Utilities;
using ZaminAggregateCrud.Core.Contracts.FolderName.Commands;
using ZaminAggregateCrud.Core.Contracts.FolderName.Commands.Update;
using ZaminAggregateCrud.Core.Domain.FolderName.Entities;

namespace ZaminAggregateCrud.Core.ApplicationService.Blogs.Commands.Update;

public class UpdateBlogCommandHandler : CommandHandler<UpdateBlogCommand>
{

    private readonly IBlogCommandRepository _commandRepository;

    public UpdateBlogCommandHandler(ZaminServices zaminServices, IBlogCommandRepository commandRepository)
        : base(zaminServices)
    {
        _commandRepository = commandRepository;
    }

    public override async Task<CommandResult> Handle(UpdateBlogCommand request)
    {
        Blog entity = await _commandRepository.GetAsync(request.BlogId);

        if (entity is null)
        {
            throw new InvalidEntityStateException("VALIDATION_ERROR_NOT_EXIST", nameof(entity));
        }
        entity.Update(request.ToParameter());

        await _commandRepository.CommitAsync();

        return Ok();
    }
}
