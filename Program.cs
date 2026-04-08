using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyInventory2026.src.shared.context;
using MyInventory2026.src.shared.helpers;


try
{
    var context = DbContextFactory.Create();

    if (context.Database.CanConnect())
    {
        Console.WriteLine("Conexión a la base de datos exitosa.");
    }
    else
    {
        Console.WriteLine("No se pudo conectar a la base de datos.");
    }
}
catch (Exception ex)
{
    Console.Error.WriteLine($"Ocurrió un error al intentar conectar a la base de datos: {ex.Message}"); 
    if (ex.InnerException != null)
    {
        Console.WriteLine($"Detalle: {ex.InnerException.Message}");
    }
}
