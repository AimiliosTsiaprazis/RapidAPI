using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RapidApi.Services
{
    public class FootballService
    {
        private readonly HttpClient _httpClient;
        public FootballService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        // Teams Statistics
        public async Task<string> GetTeamsStats()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api-football-v1.p.rapidapi.com/v3/teams/countries")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "" );

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            
            return await response.Content.ReadAsStringAsync();
        }
    }
}