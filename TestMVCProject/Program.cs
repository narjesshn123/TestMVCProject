using MinimalProject.Catalog.Domain.Primitive.Contract;
using MinimalProject.Catalog.Domain.Products;
using MinimalProject.Catalog.Infrastructure.Repository;
using TestMVCProject.Application;
using TestMVCProject.Application.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews()
    .AddRazorOptions(options =>
    {
        options.ViewLocationFormats.Clear();     
 
        options.ViewLocationFormats.Add("/Presentation/Views/{1}/{0}.cshtml"); // برای ویوهای Product, Category
        options.ViewLocationFormats.Add("/Presentation/Views/Shared/{0}.cshtml");
    });
builder.Services.AddScoped<IProductRepository, ProductRepository>();  
builder.Services.AddScoped<IProductManager, ProductManager>();
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
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();
