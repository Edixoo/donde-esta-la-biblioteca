using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;
using Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(); 
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<LibraryContext>(options =>
    options.UseSqlite(@"Data Source=C:\\Users\\akimo\\OneDrive\\Bureau\\donde-esta-la-biblioteca\\ressources\\library.db;"));
                
builder.Services.AddScoped<ICatalogManager, CatalogManager>();
builder.Services.AddScoped<ICatalogService, CatalogService>();
builder.Services.AddScoped<IRepository<Book>, BookRepository>();
builder.Services.AddScoped<IRepository<Author>, AuthorRepository>();
builder.Services.AddScoped<IRepository<Library>, LibraryRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();