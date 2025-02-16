using System.Text.Json.Serialization;

namespace SRApi.Models
{
    public class ChannelList
    {
        [JsonPropertyName("channels")]
        public List<Channel> Channels { get; set; } 
    }
}
