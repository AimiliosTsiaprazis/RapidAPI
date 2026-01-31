using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RapidApi.Services
{
    public class DeepTranslateService
    {
        private readonly HttpClient _httpClient;
        public DeepTranslateService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> GetLanguagesAsync()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://deep-translate1.p.rapidapi.com/language/translate/v2/languages"),
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}