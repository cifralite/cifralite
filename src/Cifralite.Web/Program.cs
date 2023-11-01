using Cifralite.Web.Core.Data;
using Cifralite.Web.Core.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<MusicaService>();


if (builder.Environment.IsEnvironment("Testing"))
{
    builder.Services.AddDbContext<IDbContext, AppDbContext>(options =>
    {
        options.UseInMemoryDatabase("Cifralite");
    });
}

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<IDbContext, AppDbContextSqlite>();
}

if (builder.Environment.IsProduction())
{
    builder.Services.AddDbContext<IDbContext, AppDbContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
    });
}

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
