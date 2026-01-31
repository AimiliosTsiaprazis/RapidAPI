using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RapidApi.Services;

[ApiController]
[Route("api/[controller]")]
public class BinIpCheckerController : ControllerBase
{
    private readonly BinIpCheckerService _binIpCheckerService;
    public BinIpCheckerController(BinIpCheckerService binIpCheckerService)
    {
        _binIpCheckerService = binIpCheckerService;
    }
    //IP Lookup API
    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetIpLookup()
    {
        var result = await _binIpCheckerService.GetIpLookup();
        return Ok(result);
    }
}