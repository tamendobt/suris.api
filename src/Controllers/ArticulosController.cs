using Microsoft.AspNetCore.Mvc;
using suris.api.src.Models;
using suris.api.src.Services;

namespace suris.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArticulosController : ControllerBase
{
    private readonly IArticuloService _articuloService;
    public ArticulosController(IArticuloService articuloService)
    {
        _articuloService = articuloService;
    }
    [HttpGet]
    public ActionResult getArticulosByDeposito([FromQuery] int deposito)
    {
        List<Articulo> response = _articuloService.GetArticulosByDeposito(deposito);
        return Ok(response);
    }
}
