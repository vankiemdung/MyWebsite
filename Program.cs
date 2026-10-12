var builder = WebApplication.CreateBuilder(args);

// Add MVC (controllers + views)
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();   // serves files from wwwroot (css, js, images)

app.UseRouting();

// URL pattern: /{controller}/{action}, e.g. /Home/Hobbies
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
