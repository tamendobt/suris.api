using System.ComponentModel.DataAnnotations;

namespace suris.api.src.Dtos
{
    public class CreatePedidosRequestDto
    {
        [Required]
        public PedidoDto Pedido { get; set; }
    }
}
