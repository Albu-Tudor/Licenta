using AppService.Domain.DataSource;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace AppService.Infrastructure.DataSources.Persistence
{
    public class DataSourceConfiguration : IEntityTypeConfiguration<DataSource>
    {
        public void Configure(EntityTypeBuilder<DataSource> builder)
        {
            builder
                .HasMany(e => e.Files)
                .WithOne(e => e.DataSource)
                .HasForeignKey(e => e.DataSourceId)
                .IsRequired();
        }
    }
}
