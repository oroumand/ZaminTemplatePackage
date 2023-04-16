using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;
using ZaminAggregateCrud.Core.Contracts.FolderName.Commands;
using ZaminAggregateCrud.Core.Contracts.FolderName.Commands.Create;
using ZaminAggregateCrud.Core.Domain.FolderName.Entities;

namespace ZaminAggregateCrud.Core.ApplicationService.FolderName.Commands.Create;

public class CreateBlogCommandHandler : CommandHandler<CreateBlogCommand>
{

    private readonly IBlogCommandRepository _blogCommandRepository;

    public CreateBlogCommandHandler(ZaminServices zaminServices, IBlogCommandRepository blogCommandRepository)
        : base(zaminServices)
    {
        _blogCommandRepository = blogCommandRepository;
    }

    public override async Task<CommandResult> Handle(CreateBlogCommand request)
    {
        Blog blog = new(request.BusunessId);

        await _blogCommandRepository.InsertAsync(blog);

        await _blogCommandRepository.CommitAsync();

        return await OkAsync();
    }
}
