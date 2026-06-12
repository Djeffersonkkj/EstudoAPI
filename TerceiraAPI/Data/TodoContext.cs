using Microsoft.EntityFrameworkCore;
using TerceiraAPI.Models;

namespace TerceiraAPI.Data;

public class TodoContext : DbContext
{
    public TodoContext (DbContextOptions<TodoContext> options) : base(options)
    {
        
    }

    public DbSet<TodoItem> TodoItem { get; set; } = null!;
}
