using Microsoft.AspNetCore.Mvc;
using SRApi.Services;
using SRApi.Models;

namespace SRApi.Controllers
{
    [Route("api/channels")]
    [ApiController]
    public class ChannelsController(SverigesRadioApiService sverigesRadioApiService) : Controller
    {     
        private readonly SverigesRadioApiService _sverigesRadioApiService = sverigesRadioApiService; 

        [HttpGet]
        public async Task<ActionResult<List<Channel>>> GetChannels(int page)
        {
            var result = await _sverigesRadioApiService.GetChannelsAsync(page);
            return Ok(result);
        }

    }
}
