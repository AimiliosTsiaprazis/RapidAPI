using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RapidApi.Services;

[ApiController]
[Route("api/[controller]")]
public class TheRundownController : ControllerBase
{
    private readonly TheRundownService _theRundownService;
    public TheRundownController(TheRundownService theRundownService)
    {
        _theRundownService = theRundownService;
    }

    // Affiliates
    [HttpGet("affiliates")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAffiliates()
    {
        var result = await _theRundownService.GetAffiliates();
        return Ok(result);
    }
    // Sports
    [HttpGet("sports")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetSports()
    {
        var result = await _theRundownService.GetSports();
        return Ok(result);
    }
    // Events-games
    [HttpGet("events-games")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetEventsGames()
    {
        var result = await _theRundownService.GetEventsGames();
        return Ok(result);
    }
    // Openers
    [HttpGet("openers")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetOpeners()
    {
        var result = await _theRundownService.GetOpeners();
        return Ok(result);
    }
    // Closing
    [HttpGet("closing")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetClosing()
    {
        var result = await _theRundownService.GetClosing();
        return Ok(result);
    }
    // Totals
    [HttpGet("totals")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetTotals()
    {
        var result = await _theRundownService.GetTotals();
        return Ok(result);
    }
    // Moneyline
    [HttpGet("moneyline")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetMoneyline()
    {
        var result = await _theRundownService.GetMoneyline();
        return Ok(result);
    }
    // Spread
    [HttpGet("spread")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetSpread()
    {
        var result = await _theRundownService.GetSpread();
        return Ok(result);
    }
    // Divisions
    [HttpGet("divisions")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetDivisions()
    {
        var result = await _theRundownService.GetDivisions();
        return Ok(result);
    }
    // Conferences
    [HttpGet("conferences")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetConferences()
    {
        var result = await _theRundownService.GetConferences();
        return Ok(result);
    }
    // Teams
    [HttpGet("teams")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetTeams()
    {
        var result = await _theRundownService.GetTeams();
        return Ok(result);
    }
    // Schedules
    [HttpGet("schedules")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetSchedules()
    {
        var result = await _theRundownService.GetSchedules();
        return Ok(result);
    }
}