using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MusicApp.Data;
using Microsoft.AspNetCore.Identity;
using MusicApp.Areas.Identity.Data;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MusicAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MusicAppContext") ?? throw new InvalidOperationException("Connection string 'MusicAppContext' not found.")));

/*builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AuthDbContext>();*/
builder.Services.AddDbContext<AuthDbContext>();
builder.Services.AddDefaultIdentity<ApplicationUser>().AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<AuthDbContext>()
            .AddDefaultTokenProviders();

builder.Services.AddMvc();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
