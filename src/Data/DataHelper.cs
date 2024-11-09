using suris.api.src.Dtos;
using suris.api.src.Models;
using System.Text.Json;

namespace suris.api.src.Data;

public static class DataHelper
{
    public static List<Articulo> GenerateArticulos()

    {
        using (StreamReader r = new StreamReader("src/Data/articulosSeed.json"))
        {
            string articulosJson = r.ReadToEnd();
            JsonSerializerOptions options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
            ArticuloSeedDto articulosDto = JsonSerializer.Deserialize<ArticuloSeedDto>(articulosJson, options);
            return articulosDto.Articulos;
        }
    }
}