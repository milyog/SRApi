using System.Net.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using SRApi.Models;

namespace SRApi.Services
{
    public class SverigesRadioApiService(IHttpClientFactory httpClientFactory)
    {
        private readonly HttpClient _httpClient = httpClientFactory.CreateClient("SverigesRadioApi");

        //public SverigesRadioApiService(IHttpClientFactory httpClentFactory)
        //{
        //    _httpClient = httpClentFactory.CreateClient("SverigesRadioApi");
        //}

        public async Task<List<Channel>> GetChannelsAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("channels?format=json");
                response.EnsureSuccessStatusCode();

                var rawData = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"apidata: {rawData}");

                //var data = JsonConvert.DeserializeObject<ChannelList>(response);

                var result = await response.Content.ReadFromJsonAsync<ChannelList>();
                var channels = result?.Channels ?? new List<Channel>(); // Skydda mot null

                //var channelsTest = await response.Content.ReadFromJsonAsync<List<Channel>>();
                return channels; ;//await response.Content.ReadFromJsonAsync<List<Channel>>() ?? new List<Channel>();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Request error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            return new List<Channel>(); // FIXA                                       
        }
    }
}
