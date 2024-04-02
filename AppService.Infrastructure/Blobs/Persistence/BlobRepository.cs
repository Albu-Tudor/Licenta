using AppService.Application.Common.Interfaces;

using Azure.Storage.Blobs;

using Microsoft.AspNetCore.Http;

namespace AppService.Infrastructure.Blobs.Persistence
{
    public class BlobRepository : IBlobRepository
    {
        public async Task CreateAsync(BlobClient blobClient, IFormFile file)
        {
            using (var uploadFileStream = file.OpenReadStream())
            {
                await blobClient.UploadAsync(uploadFileStream);
                uploadFileStream.Close();
            }
        }
    }
}
