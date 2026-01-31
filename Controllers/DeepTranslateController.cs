using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using RapidApi.Services;

[ApiController]
[Route("api/[controller]")]
public class DeepTranslateController : ControllerBase
{
    private readonly DeepTranslateService _deepTranslateService;

    public DeepTranslateController(DeepTranslateService deepTranslateService)
    {
        _deepTranslateService = deepTranslateService;
    }

    // Languages API
    [HttpGet("languages")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetLanguages()
    {
        var result = await _deepTranslateService.GetLanguagesAsync();
        return Ok(result);
    }
}