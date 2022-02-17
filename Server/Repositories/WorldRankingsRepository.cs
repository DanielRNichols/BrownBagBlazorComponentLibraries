using MudBlazorGolfers.Shared;
using System.Text.Json;

namespace MudBlazorGolfers.Server.Repositories
{
    public class WorldRankingsRepository : IWorldRankingsRepository
    {
        private readonly IHostEnvironment _env;

        public WorldRankingsRepository(IHostEnvironment env)
        {
            _env = env;
        }


        public async Task<IList<WorldRankingJson>?> GetAll()
        {
            string worldRankingsJsonStr = System.IO.File.ReadAllText(_env.ContentRootPath + "/data/worldrankings.json");

            var worldRankingsJson = JsonSerializer.Deserialize<IList<WorldRankingJson>>(worldRankingsJsonStr)?.ToList();
            var response = await Task.FromResult(worldRankingsJson);

            return response;

        }
    }
}
