using Microsoft.EntityFrameworkCore;

namespace LabDemo.IDesign.Accessors;

public class UserLabsDataContext : DbContext
{
    public UserLabsDataContext(DbContextOptions<UserLabsDataContext> options) : base(options)
    {
    }

    public DbSet<UserLabEntity> UserLabs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserLabEntity>()
            .HasKey(u => u.Id);
    }
}
