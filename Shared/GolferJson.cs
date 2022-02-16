using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MudBlazorGolfers.Shared
{
    public class GolferJson
    {
        [JsonPropertyName("pid")]
        public string Id { get; set; } = string.Empty;
        [JsonPropertyName("nameF")]
        public string FirstName { get; set; } = string.Empty;
        [JsonPropertyName("nameMI")]
        public string MiddleInitial { get; set; } = string.Empty;
        [JsonPropertyName("nameL")]
        public string LastName { get; set; } = string.Empty;
        [JsonPropertyName("ct")]
        public string Country { get; set; } = string.Empty;
    }
}
