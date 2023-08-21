using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZaminTemplate.Infra.Data.Sql.Queries.FolderName.Entities;

namespace ZaminTemplate.Infra.Data.Sql.Queries.FolderName.Configs;

public sealed class AggregateNameConfig : IEntityTypeConfiguration<AggregateName>
{
    public void Configure(EntityTypeBuilder<AggregateName> builder)
    {
        builder.Property(c => c.BusinessId).IsRequired();
        builder.HasIndex(c => c.BusinessId).IsUnique();
    }
}