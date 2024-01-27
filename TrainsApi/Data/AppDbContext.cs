using Microsoft.EntityFrameworkCore;
using TrainsApi.Data.Entities;

public class AppDbContext : DbContext
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


        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Employee> Employees { get; set; }
	public DbSet<Location> Locations { get; set; }
	public DbSet<Timetable> Timetables { get; set; }
	public DbSet<TimetableEntry> TimetableEntries { get; set; }
	public DbSet<Train> Trains { get; set; }
	public DbSet<Wagon> Wagons { get; set; }
}