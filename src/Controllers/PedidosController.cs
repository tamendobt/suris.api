using Microsoft.AspNetCore.Mvc;
using suris.api.src.Dtos;
using suris.api.src.Services;

namespace suris.api.src.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        IPedidoService _pedidoService;
        public PedidosController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpPost]
        public ActionResult CreatePedidos(PedidoDto pedidoDto)
        {
            CreatePedidoReponseDto res = _pedidoService.CreatePedidos(pedidoDto);
            if (res.Success)
            {
                return Ok(res);
            }
            else
            {
                return BadRequest(res);
            }
        }
    }
}
