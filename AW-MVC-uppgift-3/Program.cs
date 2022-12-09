using AW_MVC_uppgift_3.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<DataService>(); // Registrera för DI - ny instans varje gång
builder.Services.AddSingleton<DataService>(); // Registrera för DI - samma instans varje gång
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(o => o.MapControllers());

app.Run();
