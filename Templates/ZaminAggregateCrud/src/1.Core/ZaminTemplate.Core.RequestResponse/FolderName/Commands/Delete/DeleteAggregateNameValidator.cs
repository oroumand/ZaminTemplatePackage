using FluentValidation;

namespace ZaminTemplate.Core.RequestResponse.FolderName.Commands.Delete;

public sealed class DeleteAggregateNameValidator : AbstractValidator<DeleteAggregateNameCommand>
{
    public DeleteAggregateNameValidator()
    {
    }
}