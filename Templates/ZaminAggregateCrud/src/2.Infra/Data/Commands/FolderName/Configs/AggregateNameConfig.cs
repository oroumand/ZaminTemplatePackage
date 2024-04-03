using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZaminTemplate.Core.Domain.FolderName.Entities;

namespace ZaminTemplate.Infra.Data.Sql.Commands.FolderName.Configs;

public sealed class AggregateNameConfig : IEntityTypeConfiguration<AggregateName>
{
    public void Configure(EntityTypeBuilder<AggregateName> builder)
    {
        builder.Property(c => c.BusinessId).IsRequired();
        builder.HasIndex(c => c.BusinessId).IsUnique();
    }
}