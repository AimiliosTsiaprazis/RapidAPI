using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class GeoController : ControllerBase
{
    private readonly GeoDbService _geoDbService;

    public GeoController(GeoDbService geoDbService)
    {
        _geoDbService = geoDbService;
    }

    // Cities API
    [HttpGet("cities")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetCities()
    {
        var result = await _geoDbService.GetCitiesAsync();
        return Ok(result);
    }

    // Countries API
    [HttpGet("countries")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetCountries()
    {
        var result = await _geoDbService.GetCountriesAsync();
        return Ok(result);
    }

    // Admin Divisions API
    [HttpGet("AdminDivisions")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAdminDivisions()
    {
        var result = await _geoDbService.GetAdminDivisionsAsync();
        return Ok(result);
    }
}