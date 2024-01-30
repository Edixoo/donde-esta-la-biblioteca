﻿using BusinessLayer.Catalog;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using DataAccessLayer.Repository;
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
                services.AddScoped<ICatalogService, CatalogService>();
                services.AddScoped<ICatalogManager, CatalogManager>();
                // Configuration des services
            })
            .Build();
        
    }
}