namespace suris.api.src.Models
{
    public class Articulo
    {
        public required string Codigo { get; set; }
        public required string Descripcion { get; set; }
        public required float Precio { get; set; }
        public required int Deposito { get; set; }
    }
}
