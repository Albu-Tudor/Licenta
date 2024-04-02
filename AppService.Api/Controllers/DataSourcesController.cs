using AppService.Contracts.DatsaSources;

using Microsoft.AspNetCore.Mvc;

namespace AppService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataSourcesController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateDataSourceRequest request)
        {
            return Ok(1);
        }
    }
}
