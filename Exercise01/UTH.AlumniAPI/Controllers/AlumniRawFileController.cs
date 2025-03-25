using Microsoft.AspNetCore.Mvc;

namespace UTH.AlumniAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AlumniRawFileController : ControllerBase
{
    [HttpGet("xml")]
    public async Task<IActionResult> XML()
    {
        var filePath = Path.Combine("Resources", "AlumniData.xml");
        if (!System.IO.File.Exists(filePath))
        {
            return NotFound();
        }

        var xmlContent = await System.IO.File.ReadAllTextAsync(filePath);
        return Content(xmlContent, "application/xml");
    }

    [HttpGet("json")]
    public async Task<IActionResult> Json()
    {
        var filePath = Path.Combine("Resources", "AlumniData.json");
        if (!System.IO.File.Exists(filePath))
        {
            return NotFound();
        }

        var jsonContent = await System.IO.File.ReadAllTextAsync(filePath);
        return Content(jsonContent, "application/json");
    }
}

