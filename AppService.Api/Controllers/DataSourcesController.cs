using AppService.Application.Interfaces;
using AppService.Contracts.DatsaSources;

using Microsoft.AspNetCore.Mvc;

namespace AppService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataSourcesController : ControllerBase
    {
        private readonly IBlobService _blobService;

        public DataSourcesController(IBlobService blobService)
        {
            _blobService = blobService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] IEnumerable<IFormFile> file)
        {
            await _blobService.CreateAsync(file.First());

            return Ok(1);
        }
    }
}
