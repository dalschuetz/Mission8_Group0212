using Microsoft.EntityFrameworkCore;

namespace Mission8_Group212.Models;

public class Mission8Context : DbContext
{
    public Mission8Context(DbContextOptions<Mission8Context> options) : base(options)
    {
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<TaskModel> Tasks { get; set; }
    public DbSet<Quadrant> Quadrants { get; set; }
}