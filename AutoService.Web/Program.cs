using System.IO;
using Microsoft.EntityFrameworkCore;
using AutoService.Infrastructure.Data;
using AutoService.Web.Components;

var builder = WebApplication.CreateBuilder(args);

var dbPath = @"D:\AutoServiceSolution\autoservice.db";

Console.WriteLine("USING DB: " + dbPath);
// Path.Combine(
//      builder.Environment.ContentRootPath, 
//      Directory.GetCurrentDirectory(),
//      "..",
//      "autoservice.db"
//  );

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite($"Data Source={dbPath}"));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// using (var scope = app.Services.CreateScope())
// {
//     var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
//     db.Database.Migrate();
// }

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
