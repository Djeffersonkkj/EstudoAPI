using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using MinimolApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppContext>(options => options.UseInMemoryDatabase("Macaco"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();

app.MapGet("/macacos", async (AppContext dbcontext) => 
    await dbcontext.Macaco.ToListAsync());

app.MapGet("/macaco/{id}/{nome}", async (int id, string nome, AppContext dbcontext) =>
    await dbcontext.Macaco.FirstOrDefaultAsync(macaco => macaco.Id == id));

app.MapPost("/macacos", async (Macaco macaco, AppContext dbContext) =>
{
    dbContext.Macaco.Add(macaco);
    await dbContext.SaveChangesAsync();

    return macaco;
});

app.UseSwaggerUI();

app.Run();

public class AppContext : DbContext
{
    public AppContext(DbContextOptions options) : base(options) {}

    public DbSet<Macaco> Macaco { get; set; }
}

