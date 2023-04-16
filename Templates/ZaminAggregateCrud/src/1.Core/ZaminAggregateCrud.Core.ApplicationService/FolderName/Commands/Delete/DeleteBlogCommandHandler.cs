using System.Xml.Linq;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Core.Contracts.Data.Commands;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Exceptions;
using Zamin.Utilities;
using ZaminAggregateCrud.Core.Contracts.FolderName.Commands;
using ZaminAggregateCrud.Core.Contracts.FolderName.Commands.Delete;
using ZaminAggregateCrud.Core.Domain.FolderName.Entities;

namespace ZaminAggregateCrud.Core.ApplicationService.Blogs.Commands.Delete;

public class DeleteBlogCommandHandler : CommandHandler<DeleteBlogCommand>
{

    private readonly IBlogCommandRepository _blogCommandRepository;

    public DeleteBlogCommandHandler(ZaminServices zaminServices, IBlogCommandRepository blogCommandRepository)
        : base(zaminServices)
    {
        _blogCommandRepository = blogCommandRepository;
    }

    public override async Task<CommandResult> Handle(DeleteBlogCommand request)
    {
        Blog blog = await _blogCommandRepository.GetAsync(request.BlogId);

        if (blog is null)
        {
            throw new InvalidEntityStateException("VALIDATION_ERROR_NOT_EXIST", nameof(blog));
        }
       
        blog.Delete();
        _blogCommandRepository.Delete(blog);
        await _blogCommandRepository.CommitAsync();

        return Ok();
    }
}
