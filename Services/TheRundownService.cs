using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RapidApi.Services
{
    public class TheRundownService
    {
        private readonly HttpClient _httpClient;
        public TheRundownService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Get Affiliates
        public async Task<string> GetAffiliates()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://therundown-therundown-v1.p.rapidapi.com/affiliates")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        // Get Sports
        public async Task<string> GetSports()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://therundown-therundown-v1.p.rapidapi.com/sports")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        // Get Events - Games
        public async Task<string> GetEventsGames()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://therundown-therundown-v1.p.rapidapi.com/sports/2/events/2020-09-20?include=scores&affiliate_ids=1%2C2%2C3&offset=0")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        // Openers
        public async Task<string> GetOpeners()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://therundown-therundown-v1.p.rapidapi.com/sports/2/openers/2020-09-20?offset=300&include=scores%26include%3Dall_periods")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        // Closing
        public async Task<string> GetClosing()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://therundown-therundown-v1.p.rapidapi.com/sports/2/closing/2020-11-16?offset=300&include=scores%26include%3Dall_periods")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");
            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        // Totals
        public async Task<string> GetTotals()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://therundown-therundown-v1.p.rapidapi.com/lines/%7Bline-id%7D/total?include=all_periods")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        // Moneyline
        public async Task<string> GetMoneyline()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://therundown-therundown-v1.p.rapidapi.com/lines/10978226/moneyline?include=all_periods")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        // Spread
        public async Task<string> GetSpread()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://therundown-therundown-v1.p.rapidapi.com/lines/10978226/spread?include=all_periods")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        // Divisions
        public async Task<string> GetDivisions()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://therundown-therundown-v1.p.rapidapi.com/sports/1/divisions")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        // Conferences
        public async Task<string> GetConferences()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://therundown-therundown-v1.p.rapidapi.com/sports/1/conferences")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        // Teams
        public async Task<string> GetTeams()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://therundown-therundown-v1.p.rapidapi.com/sports/2/teams")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        // Schedules
        public async Task<string> GetSchedules()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://therundown-therundown-v1.p.rapidapi.com/sports/2/schedule?limit=100")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}