using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudBlazorGolfers.Shared
{
    public class WorldRanking
    {
        public string Id { get; set; } = String.Empty;
        public string Rank { get; set; } = String.Empty;
        public string PreviousRank { get; set; } = String.Empty;

        public Golfer Golfer { get; set; } = new Golfer();
    }
}
