using FluentValidation;

namespace ZaminTemplate.Core.RequestResponse.FolderName.Commands.Update;

public sealed class AggregateNameUpdateValidator : AbstractValidator<AggregateNameUpdateCommand>
{
    public AggregateNameUpdateValidator()
    {
    }
}