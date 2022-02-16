using AutoMapper;
using MudBlazorGolfers.Shared;

namespace MudBlazorGolfers.Server.MappingProfiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<GolferJson, Golfer>();
            CreateMap<WorldRankingJson, WorldRanking>();
        }
    }
}
