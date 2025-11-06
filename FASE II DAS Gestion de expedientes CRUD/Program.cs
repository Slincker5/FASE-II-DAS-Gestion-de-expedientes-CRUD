using FASE_II_DAS_Gestion_de_expedientes_CRUD.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<GestionexpedienteContext>(options =>
    options.UseSqlServer("Server=localhost;Database=GESTIONEXPEDIENTE;User Id=sa;Password=12345678;TrustServerCertificate=True;"));

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// 4️⃣ Ruta por defecto (Home → Index)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
