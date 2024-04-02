using Microsoft.AspNetCore.Http;

namespace AppService.Contracts.DatsaSources
{
    public class CategoryFilePair
    {
        public IEnumerable<IFormFile> Files { get; set; } = null!;
        public string Category { get; set; } = null!;
    }
}
