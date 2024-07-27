using examen_U2.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace examen_U2.Database
{
    public class ExamenSeeder
    {
        public static async Task LoadDataAsync(
      ExamenContext context,
      ILoggerFactory loggerFactory
      )
        {
            try
            {
                await LoadClientesAsync(loggerFactory, context);
 
            }
            catch (Exception e)
            {
                var logger = loggerFactory.CreateLogger<ExamenSeeder>();
                logger.LogError(e, "Error inicializando la data del API");
            }
        }
        public static async Task LoadClientesAsync(ILoggerFactory loggerFactory, ExamenContext context)
        {
            try
            {
                var jsonFilePath = "SeedData/Clientes.json";
                var jsonContent = await File.ReadAllTextAsync(jsonFilePath);
                var clientes = JsonConvert.DeserializeObject<List<ClienteEntity>>(jsonContent);

                //if (!await context.Clientes.AnyAsync())
                //{
                //    for (int i = 0; i < clientes.Count; i++)
                //    {
                //        clientes[i].CreatedBy = "7fc2cdf1-a339-4c13-88d4-82a32810d5c0";
                //        clientes[i].CreatedDate = DateTime.Now;
                //        clientes[i].UpdatedBy = "7fc2cdf1-a339-4c13-88d4-82a32810d5c0";
                //        clientes[i].UpdatedDate = DateTime.Now;
                //    }

                //    context.AddRange(clientes);
                //    await context.SaveChangesAsync();
                //}
            }
            catch (Exception e)
            {
                var logger = loggerFactory.CreateLogger<ExamenSeeder>();
                logger.LogError(e, "Error al ejecutar el Seed de categorias");
            }
        }
    }
}
