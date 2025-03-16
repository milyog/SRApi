using System.Text.Json.Serialization;

namespace SRApi.Models
{
    public class ChannelsAndPagination
    {
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }

        [JsonPropertyName("channels")]
        public List<Channel> Channels { get; set; } 
    }
}
