using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RapidApi.Services
{
    public class BinIpCheckerService
    {
        private readonly HttpClient _httpClient;
        public BinIpCheckerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> GetIpLookup()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://bin-ip-checker.p.rapidapi.com/ip-lookup?ip=2.56.188.79")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            
            return await response.Content.ReadAsStringAsync();
        }
    }
}