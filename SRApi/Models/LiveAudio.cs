using System.Text.Json.Serialization;

namespace SRApi.Models
{
    public class LiveAudio
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("statkey")]
        public string StatKey { get; set; }
    }
}
