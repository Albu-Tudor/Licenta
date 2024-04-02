using Microsoft.AspNetCore.Http;

namespace AppService.Application.Interfaces
{
    public interface IBlobService
    {
        Task<string> CreateAsync(IFormFile file);
    }
}
