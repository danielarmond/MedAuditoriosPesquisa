using MedAuditoriosPesquisa.Data;
using MedAuditoriosPesquisa.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("MedAuditoriosPesquisaContext");
builder.Services.AddDbContext<MedAuditoriosPesquisaContext>(opts =>
opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddScoped<StatusPrimarioService>();
builder.Services.AddScoped<StatusSecundarioService>();
builder.Services.AddScoped<ContatoService>();
builder.Services.AddScoped<LocalService>();


builder.Services.AddRazorPages();


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
