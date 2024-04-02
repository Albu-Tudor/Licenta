using Azure.Storage.Blobs;

using Microsoft.AspNetCore.Http;

namespace AppService.Application.Common.Interfaces
{
    public interface IBlobRepository
    {
        Task CreateAsync(BlobClient blobClient, IFormFile file);
    }
}
