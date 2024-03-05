using Refit;
using SmartSchool.Web.Components;
using SmartSchool.Web.Extensions.FrameworkExtensions;
using SmartSchool.Web.Services.BffApiClient;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.ConfigureIdentity();
builder.Services.ConfigureAuthentication(); 

builder.Services.AddRefitClient<IBffApiClient>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("http://smartschool.bff"));

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
