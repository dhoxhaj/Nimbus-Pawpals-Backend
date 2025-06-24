using Back_End.Models;
using Back_End.Services.ServicesInterface;
using Microsoft.AspNetCore.Mvc;

namespace Back_End.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FirstController : Controller
{
    private readonly IFirst _first;

    public FirstController(IFirst first)
    {
        _first = first;
    }

    [HttpGet("get-all-managers")]
    public async Task<IActionResult> getAllManagers()
    {
        var result = await _first.getAllManagers();
        return Ok(result);
    }
}