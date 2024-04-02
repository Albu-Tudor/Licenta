using AppService.Domain.DataSource;

namespace AppService.Application.Interfaces
{
    public interface IDataSourceService
    {
        Task<DataSource> Create();
    }
}
