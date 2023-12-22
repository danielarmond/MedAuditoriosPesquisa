using MedAuditoriosPesquisa.Data;
using MedAuditoriosPesquisa.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("MedAuditoriosPesquisaContext");
builder.Services.AddDbContext<MedAuditoriosPesquisaContext>(opts =>
opts.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<MedAuditoriosPesquisaContext>();

builder.Services.AddScoped<StatusPrimarioService>();
builder.Services.AddScoped<StatusSecundarioService>();
builder.Services.AddScoped<LocalService>();
builder.Services.AddScoped<UsuarioService>();
builder.Services.AddScoped<FilialService>();


builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseRouting();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
