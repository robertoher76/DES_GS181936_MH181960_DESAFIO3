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

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Administrador", policy => policy.RequireRole("Administrador"));
    options.AddPolicy("Usuario", policy => policy.RequireRole("Usuario"));   
});

builder.Services.AddIdentity<Usuario, IdentityRole>()
    .AddEntityFrameworkStores<ProyectoContext>()
    .AddDefaultTokenProviders()
    .AddApiEndpoints();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<Usuario>>();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var roles = new[] { "Administrador", "Usuario" };

    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }    

    // Verifica si el usuario administrador ya existe
    var adminUser = await userManager.FindByEmailAsync("admin@gmail.com");

    if (adminUser == null)
    {
        // Crear el usuario administrador
        var newAdminUser = new Usuario
        {
            UserName = "admin@gmail.com",
            Email = "admin@gmail.com",
            EmailConfirmed = true
        };

        // Establecer una contraseña para el usuario administrador
        var result = await userManager.CreateAsync(newAdminUser, "Password123$");

        // Si el usuario se creó exitosamente, asignar el rol de Admin
        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(newAdminUser, "Administrador");
        }
        else
        {            
            foreach (var error in result.Errors)
            {
                Console.WriteLine($"Error creando usuario administrador: {error.Description}");
            }
        }
    }

    // Verifica si el usuario normal ya existe
    var normalUser = await userManager.FindByEmailAsync("user@gmail.com");

    if (normalUser == null)
    {
        // Crear el usuario administrador
        var newNormalUser = new Usuario
        {
            UserName = "user@gmail.com",
            Email = "user@gmail.com",
            EmailConfirmed = true
        };

        // Establecer una contraseña para el usuario administrador
        var result = await userManager.CreateAsync(newNormalUser, "Password123$");

        // Si el usuario se creó exitosamente, asignar el rol de Admin
        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(newNormalUser, "Usuario");
        }
        else
        {
            foreach (var error in result.Errors)
            {
                Console.WriteLine($"Error creando usuario administrador: {error.Description}");
            }
        }
    }
}

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
