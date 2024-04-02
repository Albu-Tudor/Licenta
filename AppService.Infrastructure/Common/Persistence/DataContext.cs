using Microsoft.EntityFrameworkCore;

using DomainModel = AppService.Domain.DataSource;

namespace AppService.Infrastructure.Common.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<DomainModel.DataSource> DataSources { get; set; }
        public DbSet<DomainModel.File> Files { get; set; }
    }
}
