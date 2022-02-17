using MudBlazorGolfers.Shared;
using System.Text.Json;

namespace MudBlazorGolfers.Server.Repositories
{
    public class GolfersRepository : IGolfersRepository
    {
        private readonly IHostEnvironment _env;

        public GolfersRepository(IHostEnvironment env)
        {
            _env = env;
        }


        public async Task<IList<GolferJson>?> GetAll()
        {
            string golfersJsonString = System.IO.File.ReadAllText(_env.ContentRootPath + "/data/players.json");

            var golfersJson = JsonSerializer.Deserialize<IList<GolferJson>>(golfersJsonString)?.ToList();
            var response = await Task.FromResult(golfersJson);

            return response;

        }
    }
}
