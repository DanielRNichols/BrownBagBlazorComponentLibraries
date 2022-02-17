using MudBlazorGolfers.Shared;

namespace MudBlazorGolfers.Server.Repositories
{
    public interface IGolfersRepository
    {
        Task<IList<GolferJson>?> GetAll();
    }
}
