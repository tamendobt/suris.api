using Microsoft.AspNetCore.Mvc;

namespace suris.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArticulosController : ControllerBase
{
    public ArticulosController()
    {

    }
    [HttpGet]
    public async Task<ActionResult> getArticulosByDeposito([FromQuery] int deposito)
    {
        return Ok();
    }
}
