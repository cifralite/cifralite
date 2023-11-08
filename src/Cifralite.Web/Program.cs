using Cifralite.Web.Core.Data;
using Cifralite.Web.Core.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<MusicaService>();
builder.Services.AddScoped<UsuarioService>();


if (builder.Environment.IsEnvironment("Testing"))
{
    builder.Services.AddDbContext<IDbContext, AppDbContext>(options =>
    {
        options.UseInMemoryDatabase("Cifralite");
    });
    builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
}

else if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<IDbContext, AppDbContextSqlite>();
    builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContextSqlite>();
}

else
{
    builder.Services.AddDbContext<IDbContext, AppDbContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
    });
    builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
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

app.UseAuthentication();
app.UseAuthorization();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
