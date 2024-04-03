using FluentValidation;

namespace ZaminTemplate.Core.RequestResponse.FolderName.Commands.Delete;

public sealed class AggregateNameDeleteValidator : AbstractValidator<AggregateNameDeleteCommand>
{
    public AggregateNameDeleteValidator()
    {
    }
}