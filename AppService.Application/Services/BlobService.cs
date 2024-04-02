
using AppService.Application.Common.Interfaces;
using AppService.Application.Interfaces;

using Azure.Storage.Blobs;

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace AppService.Application.Services
{
    public class BlobService : IBlobService
    {
        private readonly IBlobRepository _blobRepository;
        private readonly IConfiguration _configuration;

        public BlobService(IBlobRepository blobRepository, IConfiguration configuration)
        {
            _blobRepository = blobRepository;
            _configuration = configuration;
        }

        public async Task<string> CreateAsync(IFormFile file)
        {
            var conectionString = _configuration.GetSection("BlobService:ConnectionString").Value;
            var containerName = _configuration.GetSection("BlobService:ContainerName").Value;
            var blobName = Guid.NewGuid().ToString() + ".jpeg";

            var blobServiceClient = new BlobServiceClient(conectionString);
            var containerClient = blobServiceClient.GetBlobContainerClient(containerName);

            var blobClient = containerClient.GetBlobClient("images/" + blobName);

            await _blobRepository.CreateAsync(blobClient, file);

            return blobName;
        }
    }
}
