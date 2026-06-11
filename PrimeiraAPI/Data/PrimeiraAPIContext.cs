using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Models;

namespace PrimeiraAPI.Data;

public class PrimeiraAPIContext : DbContext
{
    public DbSet<Funcionario> Funcionario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=localhost;database=PetShop;trusted_connection=true;");
    }
}
