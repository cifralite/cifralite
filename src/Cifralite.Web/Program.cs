using Cifralite.Web.Core.Data;
using Cifralite.Web.Core.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<MusicaService>();
builder.Services.AddScoped<UsuarioService>();


builder.Services.AddDbContext<ContextoBD>(options =>
{
    options.UseSqlite("Data Source=../../banco.db");
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
