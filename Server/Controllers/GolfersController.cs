using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MudBlazorGolfers.Shared;
using System.Text.Json;

namespace MudBlazorGolfers.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GolfersController : ControllerBase
    {
        private readonly IHostEnvironment _env;
        private readonly IMapper _mapper;

        public GolfersController(IHostEnvironment env, IMapper mapper)
        {
            _env = env;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task <ActionResult<IList<Golfer>>> GetAll()
        {
            string golfersJsonString = System.IO.File.ReadAllText(_env.ContentRootPath + "/data/players.json");

            var golfersJson = JsonSerializer.Deserialize<IList<GolferJson>>(golfersJsonString)?.ToList();
            var golfers = _mapper.Map<IList<Golfer>>(golfersJson);

            var response = await Task.FromResult(golfers);

            return Ok(response);
        }
    }
}
