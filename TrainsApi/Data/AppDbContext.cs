using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrainsApi.Data.Entities;
using TrainsApi.Data.Seeders;

public class AppDbContext : IdentityDbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{

	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Train>()
            .HasMany(t => t.Brigade)
            .WithMany(e => e.BrigadeTrains)
            .UsingEntity(join => join.ToTable("TrainEmployeeBrigade"));

        modelBuilder.Entity<Train>()
                    .HasMany(t => t.Conductors)
                    .WithMany(e => e.ConductorTrains)
                    .UsingEntity(join => join.ToTable("TrainEmployeeConductor"));
        modelBuilder.SeedLocations();

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Employee> Employees { get; set; }
	public DbSet<Location> Locations { get; set; }
	public DbSet<Timetable> Timetables { get; set; }
	public DbSet<TimetableEntry> TimetableEntries { get; set; }
	public DbSet<Train> Trains { get; set; }
	public DbSet<Wagon> Wagons { get; set; }
    public DbSet<User> Users { get; set; }
}