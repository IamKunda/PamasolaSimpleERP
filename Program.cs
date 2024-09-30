using Microsoft.AspNetCore.Mvc;
using PamasolaSimpleERP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
// using PamasolaSimpleERP.Utils;
using PamasolaSimpleERP.Services;
using Azure.Storage.Blobs;
using PamasolaSimpleERP.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// builder.Services.AddSingleton<PasswordHasher>();
// builder.Services.AddSingleton<TokenManager>();
// builder.Services.AddSingleton<UserValidators>();
// builder.Services.AddSingleton<SendSMSService>();
// Configure Testing with Mysql
IConfiguration configuration = builder.Configuration.GetSection("ConnectionStrings");
string? connectionString = configuration.GetValue<string>("SQLServer");
// builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseMySQL(connectionString));
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString,
        sqlServerOptions => sqlServerOptions.EnableRetryOnFailure()
    )
);
// 1. Register BlobServiceClient
builder.Services.AddSingleton(x =>
{
    var connectionString = builder.Configuration.GetConnectionString("AzureBlobStorage");
    return new BlobServiceClient(connectionString);
});

// 2. Register ImageService
builder.Services.AddScoped<ImageService>();
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Add authentication services, cookie configuration
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login"; // Redirect path for login
});


// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
