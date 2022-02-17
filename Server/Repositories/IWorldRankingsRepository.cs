using MudBlazorGolfers.Shared;

namespace MudBlazorGolfers.Server.Repositories
{
    public interface IWorldRankingsRepository
    {
        Task<IList<WorldRankingJson>?> GetAll();
    }
}
