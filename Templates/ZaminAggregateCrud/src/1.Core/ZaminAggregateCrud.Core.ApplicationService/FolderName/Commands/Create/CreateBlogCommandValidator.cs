using FluentValidation;
using Zamin.Core.Domain.Toolkits.ValueObjects;
using Zamin.Extensions.Translations.Abstractions;
using ZaminAggregateCrud.Core.Contracts.FolderName.Commands.Create;

namespace ZaminAggregateCrud.Core.ApplicationService.FolderName.Commands.Create;

public class CreateBlogCommandValidator : AbstractValidator<CreateBlogCommand>
{
    public CreateBlogCommandValidator(ITranslator translator)
    {
        //RuleFor(c => c.Title)
        //    .NotNull().WithMessage(translator["Required", nameof(Title)])
        //    .MinimumLength(10).WithMessage(translator["MinimumLength", nameof(Title), "10"])
        //    .MaximumLength(100).WithMessage(translator["MaximumLength", nameof(Title), "100"]);
    }
}
