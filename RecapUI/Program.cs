using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Recap.Business.Abstract;
using Recap.Business.Concrete;
using Recap.DataAccess.EntityFramework.Context;
using Recap.DataAccess.Repositories.Abstract;
using Recap.DataAccess.Repositories.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(o => o.UseNpgsql("Server=localhost; Port=5432; Database=RecapProject1Db; uid=postgres;pwd=123"));
builder.Services.AddScoped<IProductService, ProductService>(); 
builder.Services.AddScoped<IProductRepository,EfProductRepository>();

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryRepository,EfCategoryRepository>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, EfUserRepository>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(o =>
{
    o.Cookie.Name = "RecapProject1Cookie";
    o.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    o.Cookie.HttpOnly = true;
    o.LoginPath = "/login/login";
    o.LogoutPath = "/home/index";
    o.AccessDeniedPath = "/home/index";
});

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
    pattern: "{controller=Login}/{action=Login}/{id?}");

app.Run();
