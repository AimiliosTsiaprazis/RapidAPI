using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RapidApi.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        // 5day Forecast
        public async Task<string> Get5DayForecast()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherbit-v1-mashape.p.rapidapi.com/forecast/3hourly?lat=35.5&lon=-78.5&units=imperial&lang=en")
            };

            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
        // Current Weather Data of a location
        public async Task<string> GetCurrentWeatherDataOfLocation()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherbit-v1-mashape.p.rapidapi.com/current?lon=38.5&lat=-78.5&units=imperial&lang=en")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
        // 1HourForecast
        public async Task<string> Get1HourForecast()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherbit-v1-mashape.p.rapidapi.com/forecast/minutely?lat=35.5&lon=-78.5&units=metric")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
        //16DayForecast
        public async Task<string> Get16DayForecast()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherbit-v1-mashape.p.rapidapi.com/forecast/daily?lat=38.5&lon=-78.5&units=imperial&lang=en")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
        // 120HourForecast
        public async Task<string> Get120HourForecast()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherbit-v1-mashape.p.rapidapi.com/forecast/hourly?lat=38.5&lon=-78.5&lang=en&hours=48&units=imperial")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add( "x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
        // Severe Weather Alerts
        public async Task<string> GetWeatherAlerts()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherbit-v1-mashape.p.rapidapi.com/alerts?lat=38.5&lon=-78.5")
            };
            request.Headers.Add("x-rapidapi-key", "");
            request.Headers.Add("x-rapidapi-host", "");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}