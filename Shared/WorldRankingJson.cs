using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MudBlazorGolfers.Shared
{
    public class WorldRankingJson
    {
        [JsonPropertyName("plrNum")]
        public string Id { get; set; } = string.Empty;
        [JsonPropertyName("curRank")]
        public string Rank { get; set; } = string.Empty;
        [JsonPropertyName("prevRank")]
        public string PreviousRank { get; set; } = string.Empty;
    }
}
