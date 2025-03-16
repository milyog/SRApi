using System.Net.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using SRApi.Models;

namespace SRApi.Services
{
    public class SverigesRadioApiService(IHttpClientFactory httpClientFactory)
    {
        private readonly HttpClient _httpClient = httpClientFactory.CreateClient("SverigesRadioApi");

        public async Task<ChannelsAndPagination> GetChannelsAsync(int page = 1)
        {
            try
            {
                var response = await _httpClient.GetAsync($"channels?format=json&page={page}");
                response.EnsureSuccessStatusCode();

                var result = await response.Content.ReadFromJsonAsync<ChannelsAndPagination>();

                return new ChannelsAndPagination
                {                 
                    Channels = result?.Channels ?? new List<Channel>(),
                    Pagination = result?.Pagination
                };
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Request error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }

            return null; // FIXA                                       
        }
    }
}
