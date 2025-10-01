using Microsoft.EntityFrameworkCore; 

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllersWithViews();

// Add services to the container.
// Registers your ContactContext with the dependency injection system
// This makes your database context available to controllers automatically

builder.Services.AddDbContext<ContactContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContactContext")));


builder.Services.AddRouting(options =>
{
    // this makes urls lowercase 
    options.LowercaseUrls = true;
    // adds trailing slash to urls 
    options.AppendTrailingSlash = true;
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
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

// Updates your routing pattern to include the slug parameter. 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}");

app.Run();
