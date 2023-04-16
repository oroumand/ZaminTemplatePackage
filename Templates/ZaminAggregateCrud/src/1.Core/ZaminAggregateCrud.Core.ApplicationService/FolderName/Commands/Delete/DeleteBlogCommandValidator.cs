using FluentValidation;
using Zamin.Core.Domain.Toolkits.ValueObjects;
using Zamin.Extensions.Translations.Abstractions;
using ZaminAggregateCrud.Core.Contracts.FolderName.Commands.Delete;

namespace ZaminAggregateCrud.Core.ApplicationService.FolderName.Commands.Delete;

public class DeleteBlogCommandValidator : AbstractValidator<DeleteBlogCommand>
{
    public DeleteBlogCommandValidator(ITranslator translator)
    {
        //RuleFor(c => c.Title)
        //    .NotNull().WithMessage(translator["Required", nameof(Title)])
        //    .MinimumLength(10).WithMessage(translator["MinimumLength", nameof(Title), "10"])
        //    .MaximumLength(100).WithMessage(translator["MaximumLength", nameof(Title), "100"]);
    }
}
