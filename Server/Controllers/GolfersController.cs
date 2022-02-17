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
    public class GolfersController : ControllerBase
    {
        private readonly IGolfersRepository _repo;
        private readonly IMapper _mapper;

        public GolfersController(IGolfersRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task <ActionResult<IList<Golfer>>> GetAll()
        {
            var golfersJson = await _repo.GetAll();
            var golfers = _mapper.Map<IList<Golfer>>(golfersJson);

            var response = await Task.FromResult(golfers);

            return Ok(response);
        }
    }
}
