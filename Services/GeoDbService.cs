using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

public class GeoDbService
{
    private readonly HttpClient _httpClient;

    public GeoDbService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    // Cities
    public async Task<string> GetCitiesAsync()
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://wft-geo-db.p.rapidapi.com/v1/geo/cities"),
        };
        request.Headers.Add("x-rapidapi-key", "");
        request.Headers.Add("x-rapidapi-host", "");

        using var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }
    // Countries
    public async Task<string> GetCountriesAsync()
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://wft-geo-db.p.rapidapi.com/v1/geo/countries"),
        };
        request.Headers.Add("x-rapidapi-key", "");
        request.Headers.Add("x-rapidapi-host", "");

        using var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }
    // Admin Divisions
    public async Task<string> GetAdminDivisionsAsync()
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://wft-geo-db.p.rapidapi.com/v1/geo/adminDivisions"),
        };
        request.Headers.Add("x-rapidapi-key", "");
        request.Headers.Add("x-rapidapi-host", "");

        using var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }
}