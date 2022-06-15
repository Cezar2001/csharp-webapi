using Microsoft.EntityFrameworkCore;
using csharp_api.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//registriamo context
builder.Services.AddDbContext<SingolaAttivitaContext>(opt =>
    opt.UseInMemoryDatabase("ListaAttivita"));

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
