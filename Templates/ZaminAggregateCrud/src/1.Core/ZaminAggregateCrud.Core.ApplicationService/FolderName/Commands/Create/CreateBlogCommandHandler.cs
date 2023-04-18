using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;
using ZaminAggregateCrud.Core.Contracts.FolderName.Commands;
using ZaminAggregateCrud.Core.Contracts.FolderName.Commands.Create;
using ZaminAggregateCrud.Core.Domain.FolderName.Entities;

namespace ZaminAggregateCrud.Core.ApplicationService.Blogs.Commands.Create;

public class CreateBlogCommandHandler : CommandHandler<CreateBlogCommand>
{

    private readonly IBlogCommandRepository _commandRepository;

    public CreateBlogCommandHandler(ZaminServices zaminServices, IBlogCommandRepository commandRepository)
        : base(zaminServices)
    {
        _commandRepository = commandRepository;
    }

    public override async Task<CommandResult> Handle(CreateBlogCommand request)
    {
        Blog entity = new(request.BusunessId);

        await _commandRepository.InsertAsync(entity);

        await _commandRepository.CommitAsync();

        return await OkAsync();
    }
}
