﻿using suris.api.src.Data;
using suris.api.src.Models;

namespace suris.api.src.Services;

public interface IArticuloService
{
    List<Articulo> GetArticulosByDeposito(int deposito);
}
public class ArticuloService : IArticuloService
{
    public List<Articulo> GetArticulosByDeposito(int deposito)
    {
        List<Articulo> articulos = DataHelper.GenerateArticulos();

        List<Articulo> articulosByDeposito = articulos.Where(a => a.Deposito == deposito && !a.Codigo.Any(ch => !char.IsLetterOrDigit(ch) && a.Precio > 0)).ToList();
        return articulosByDeposito;
    }
}