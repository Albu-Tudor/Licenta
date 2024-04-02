using AppService.Application.Interfaces;
using AppService.Domain.DataSource;

namespace AppService.Application.Services
{
    public class DataSourceService : IDataSourceService
    {
        private readonly IBlobService _blobService;

        public DataSourceService(IBlobService blobService)
        {
            _blobService = blobService;
        }

        public Task<DataSource> Create()
        {
            throw new NotImplementedException();
        }
    }
}
