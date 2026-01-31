using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using RapidApi.Services;

[ApiController]
[Route("api/[controller]")]
public class FootballController : ControllerBase
{
    private readonly FootballService _footballService;
    public FootballController(FootballService footballService)
    {
        _footballService = footballService;
    }
    [HttpGet("TeamsStatistics")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetTeamsStats()
    {
        var result = await _footballService.GetTeamsStats();
        return Ok(result);
    }
}