using System.Text.Json.Serialization;

namespace SRApi.Models
{
    public class Channel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("image")]
        public string Image {  get; set; }
        [JsonPropertyName("color")]
        public string Color {  get; set; }
        [JsonPropertyName("tagline")]
        public string TagLine { get; set; }
        [JsonPropertyName("siteurl")]
        public string Siteurl { get; set; }
        [JsonPropertyName("liveaudio")]
        public LiveAudio LiveAudio { get; set; }
    }
}
