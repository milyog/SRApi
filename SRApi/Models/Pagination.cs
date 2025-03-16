using System.Drawing;
using System.Text.Json.Serialization;

namespace SRApi.Models
{
    public class Pagination
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("size")]
        public int Size {  get; set; }

        [JsonPropertyName("totalhits")]
        public int TotalHits { get; set; }

        [JsonPropertyName("totalpages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("nextpage")]
        public string NextPage { get; set; }
    }
}
