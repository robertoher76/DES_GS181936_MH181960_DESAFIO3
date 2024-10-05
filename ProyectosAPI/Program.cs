using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ProyectosAPI.Models;

var builder = WebApplication.CreateBuilder(args);

//Configurar Entity Framework Core
builder.Services.AddDbContext<ProyectoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthorization();
builder.Services.AddAuthentication()
        .AddCookie(IdentityConstants.ApplicationScheme);

builder.Services.AddIdentityCore<Usuario>()
    .AddEntityFrameworkStores<ProyectoContext>()
    .AddApiEndpoints();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.MapIdentityApi<Usuario>();

app.Run();
