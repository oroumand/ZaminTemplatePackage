using FluentValidation;

namespace ZaminTemplate.Core.RequestResponse.FolderName.Commands.Create;

public sealed class AggregateNameCreateValidator : AbstractValidator<AggregateNameCreateCommand>
{
    public AggregateNameCreateValidator()
    {
    }
}