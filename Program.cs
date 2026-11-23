using Projeto_Web_Lh_Pets_versão_1;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/", () => "LH Pets - Protótipo 1");

app.MapGet("/index", () => Results.Redirect("/index.html"));

app.MapGet("/listaClientes", () =>
{
    var banco = new Banco();
    return Results.Content(banco.GetListaString(), "text/html");
});

app.Run();
