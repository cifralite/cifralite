using Cifralite.Web.Core.Data;
using Cifralite.Web.Core.Entities;
using Cifralite.Web.Core.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<MusicaService>();
builder.Services.AddScoped<UsuarioService>();
builder.Services.AddScoped<UserManager<Usuario>>();


if (builder.Environment.IsEnvironment("Testing"))
{
    builder.Services.AddDbContext<IDbContext, AppDbContext>(options =>
    {
        options.UseInMemoryDatabase("Cifralite");
    });
    builder.Services.AddDbContext<IDbContext, AppDbContext>();
    builder.Services.AddIdentity<Usuario, IdentityRole<int>>().AddEntityFrameworkStores<AppDbContext>();
}

else if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<IDbContext, AppDbContextSqlite>();
    builder.Services.AddIdentity<Usuario, IdentityRole<int>>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<AppDbContextSqlite>();
}

else
{
    builder.Services.AddDbContext<IDbContext, AppDbContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
    });
    builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
}

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/login/";
        options.AccessDeniedPath = "/login/";
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

app.UseAuthentication();
app.UseAuthorization();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
