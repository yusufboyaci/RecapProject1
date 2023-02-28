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
