using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using RapidApi.Services;

[ApiController]
[Route("api/[controller]")]
public class WeatherController : ControllerBase
{
    private readonly WeatherService _weatherService;
    public WeatherController(WeatherService weatherService)
    {
        _weatherService = weatherService;
    }
    // 5DayForecast
    [HttpGet("forecast")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Get5DayForecast()
    {
        var result = await _weatherService.Get5DayForecast();
        return Ok(result);
    }

    // CurrentWeatherDataOfLocation
    [HttpGet("currentWeatherDataOfLocation")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetCurrentWeatherDataOfLocation()
    {
        var result = await _weatherService.GetCurrentWeatherDataOfLocation();
        return Ok(result);
    }
    // 1HourForecast
    [HttpGet("1HourForecast")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Get1HourForecast()
    {
        var result = await _weatherService.Get1HourForecast();
        return Ok(result);
    }
    // 16HourForecast
    [HttpGet("16DayForecast")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Get16HourForecast()
    {
        var result = await _weatherService.Get16DayForecast();
        return Ok(result);
    }
    // 120HourForecast
    [HttpGet("120HourForecast")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Get120HourForecast()
    {
        var result = await _weatherService.Get120HourForecast();
        return Ok(result);
    }

    //SevereWeatherAlerts
    [HttpGet("severeWeatherAlerts")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetWeatherAlerts()
    {
        var result = await _weatherService.GetWeatherAlerts();
        return Ok(result);
    }
}
