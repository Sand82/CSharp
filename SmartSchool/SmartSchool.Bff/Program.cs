using Refit;
using SmartSchool.Bff.ApiClients;
using SmartSchool.Bff.Students;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRefitClient<IStudentsApiClient>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("http://students"));

var app = builder.Build();

app.AddStudentEndpoints();

app.MapDefaultEndpoints();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();