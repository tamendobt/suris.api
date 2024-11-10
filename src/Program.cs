using suris.api.src.Services;

namespace suris.api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddCors();
        builder.Services.AddControllers();
        builder.Services.AddScoped<IArticuloService, ArticuloService>();
        builder.Services.AddScoped<IPedidoService, PedidoService>();
        var app = builder.Build();

        // Configure the HTTP request pipeline.

        app.UseCors(
       options =>
         options
           .WithOrigins("http://localhost:5173")
           .AllowAnyHeader()
           .WithMethods("GET", "POST")
           .AllowCredentials()
     );

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
