using FluentValidation;
using Zamin.Core.Domain.Toolkits.ValueObjects;
using Zamin.Extensions.Translations.Abstractions;
using ZaminTemplate.Core.Contracts.Blogs.Commands.CreateBlog;

namespace ZaminTemplate.Core.ApplicationService.Blogs.Commands.CreateBlog;

public class CreateBlogCommandValidator : AbstractValidator<CreateBlogCommand>
{
    public CreateBlogCommandValidator(ITranslator translator)
    {
        RuleFor(c => c.Title)
            .NotNull().WithMessage(translator["Required", nameof(Title)])
            .MinimumLength(10).WithMessage(translator["MinimumLength", nameof(Title), "10"])
            .MaximumLength(100).WithMessage(translator["MaximumLength", nameof(Title), "100"]);

        RuleFor(c => c.Description)
            .NotNull().WithMessage(translator["Required", nameof(Description)])
            .MinimumLength(50).WithMessage(translator["MinimumLength", nameof(Description), "50"])
            .MaximumLength(500).WithMessage(translator["MaximumLength", nameof(Description), "500"]);
    }
}
