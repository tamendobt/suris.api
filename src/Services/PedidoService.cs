using suris.api.src.Dtos;

namespace suris.api.src.Services;


public interface IPedidoService
{
    public CreatePedidoReponseDto CreatePedidos(PedidoDto pedidoDto);
}
public class PedidoService : IPedidoService
{
    public CreatePedidoReponseDto CreatePedidos(PedidoDto pedidoDto)
    {
        foreach (ArticuloDto articulo in pedidoDto.Articulos)
        {
            if (articulo.Precio <= 0)
            {
                return new CreatePedidoReponseDto
                {
                    Codigo = articulo.Codigo,
                    Message = "Precio invalido.",
                    Success = false
                };
            }
            if (!validateSpecialCharacters(articulo.Descripcion))
            {
                return new CreatePedidoReponseDto
                {
                    Codigo = articulo.Codigo,
                    Message = "Descripcion invalida",
                    Success = false
                };
            }
        }
        return new CreatePedidoReponseDto()
        {
            Message = "Pedido creado con exito !",
            Success = true
        };
    }
    private bool validateSpecialCharacters(string descripcion)
    {
        foreach (var c in descripcion)
        {
            if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                return false;
        }
        return true;
    }
}
