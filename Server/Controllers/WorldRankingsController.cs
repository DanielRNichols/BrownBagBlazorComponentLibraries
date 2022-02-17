using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MudBlazorGolfers.Server.Repositories;
using MudBlazorGolfers.Shared;
using System.Text.Json;

namespace MudBlazorGolfers.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorldRankingsController : ControllerBase
    {
        private readonly IWorldRankingsRepository _wrRepo;
        private readonly IGolfersRepository _gRepo;
        private readonly IMapper _mapper;

        public WorldRankingsController(IWorldRankingsRepository wrRepo, IGolfersRepository gRepo, IMapper mapper)
        {
            _wrRepo = wrRepo;
            _gRepo = gRepo;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IList<WorldRanking>>> GetAll()
        {
            var golfersJson = await _gRepo.GetAll();
            var golfers = _mapper.Map<IList<Golfer>>(golfersJson);

            var worldRankingsJson = await _wrRepo.GetAll();
            var worldRankings = _mapper.Map<IList<WorldRanking>>(worldRankingsJson);

            foreach(var ranking in worldRankings)
            {
                var golfer = golfers.FirstOrDefault(g => g.Id == ranking.Id);
                if(golfer != null)
                    ranking.Golfer = golfer;
            }

            var response = await Task.FromResult(worldRankings);

            return Ok(response);
        }

    }
}
