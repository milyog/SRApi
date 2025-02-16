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
        public async Task<ActionResult<List<Channel>>> GetChannels()
        {
            var result = await _sverigesRadioApiService.GetChannelsAsync();
            return Ok(result);
        }

    }
}
