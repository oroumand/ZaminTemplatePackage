using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;
using ZaminTemplate.Core.Contracts.Blogs.Commands;
using ZaminTemplate.Core.Contracts.Blogs.Commands.CreateBlog;
using ZaminTemplate.Core.Domain.Blogs.Entities;

namespace ZaminTemplate.Core.ApplicationService.Blogs.Commands.CreateBlog;

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
        Blog blog = new(request.BusunessId, request.Title, request.Description);

        await _blogCommandRepository.InsertAsync(blog);

        return await OkAsync();
    }
}
