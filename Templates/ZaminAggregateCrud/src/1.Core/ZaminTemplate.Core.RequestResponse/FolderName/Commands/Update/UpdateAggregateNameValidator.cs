using FluentValidation;

namespace ZaminTemplate.Core.RequestResponse.FolderName.Commands.Update;

public sealed class UpdateAggregateNameValidator : AbstractValidator<UpdateAggregateNameCommand>
{
    public UpdateAggregateNameValidator()
    {
    }
}