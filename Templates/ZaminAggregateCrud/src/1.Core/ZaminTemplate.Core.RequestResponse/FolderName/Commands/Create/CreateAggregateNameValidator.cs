using FluentValidation;

namespace ZaminTemplate.Core.RequestResponse.FolderName.Commands.Create;

public sealed class CreateAggregateNameValidator : AbstractValidator<CreateAggregateNameCommand>
{
    public CreateAggregateNameValidator()
    {
    }
}