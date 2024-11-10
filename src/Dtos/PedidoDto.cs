using System.ComponentModel.DataAnnotations;

namespace suris.api.src.Dtos
{
    public class PedidoDto
    {
        public List<ArticuloDto> Articulos { get; set; }

        [Required]
        public string? Vendedor { get; set; }
    }
}
