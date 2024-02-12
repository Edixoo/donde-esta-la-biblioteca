using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using DataAccessLayer.Contexts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;
namespace LibraryManager;

public class Program
{
    private static void Main(string[] args)
    {
        var host = CreateHostBuilder(new ConfigurationBuilder());
        
        var catalogService = host.Services.GetRequiredService<ICatalogService>();
        
        catalogService.ShowCatalog();
        
    }
    
    private static IHost CreateHostBuilder(IConfigurationBuilder configuration)
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddDbContext<LibraryContext>(options =>
                    options.UseSqlite("Data Source=C:\\Users\akimo\\OneDrive\\Bureau\\donde-esta-la-biblioteca\\ressources\\library.db;"));
                
                services.AddScoped<ICatalogManager, CatalogManager>();
                services.AddScoped<ICatalogService, CatalogService>();
                services.AddScoped<IRepository<Book>, BookRepository>();
                services.AddScoped<IRepository<Author>, AuthorRepository>();
                services.AddScoped<IRepository<Library>, LibraryRepository>();
            })
            .Build();
        
    }
}