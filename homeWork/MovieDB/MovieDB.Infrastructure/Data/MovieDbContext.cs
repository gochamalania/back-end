using Microsoft.EntityFrameworkCore;
using MovieDB.Domain.Entities;

namespace MovieDB.Infrastructure.Data;

public class MovieDbContext : DbContext
{
    public MovieDbContext(DbContextOptions<MovieDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<Country> Countries { get; set; }
    public DbSet<Studio> Studios { get; set; }
    public DbSet<StudioDetails> StudioDetails { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Actor> Actors { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        //Country
        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(c => c.Id);
            
            entity.Property(c => c.Name).IsRequired().HasMaxLength(100);
        });
        
        //Studio
        modelBuilder.Entity<Studio>(entity =>
        {
            entity.HasKey(s => s.Id);

            entity.Property(s => s.Name).IsRequired().HasMaxLength(100);
        });
        
        //StudioDetails
        modelBuilder.Entity<StudioDetails>(entity =>
        {
            entity.HasKey(sd => sd.Id);

            entity.Property(sd => sd.LicenseNumber).IsRequired();
        });
        
        //movie
        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(m => m.Id);

            entity.Property(m => m.Title).IsRequired().HasMaxLength(150);
        });
        
        //Actor
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.HasKey(a => a.Id);

            entity.Property(a => a.FirstName).IsRequired().HasMaxLength(100);
            
            entity.Property(a => a.LastName).IsRequired().HasMaxLength(100);
        });
        
        //Country 1: Many studio
        modelBuilder.Entity<Studio>()
            .HasOne(s => s.Country)
            .WithMany(c => c.Studios)
            .HasForeignKey(s => s.CountryId)
            .OnDelete(DeleteBehavior.Restrict);
        
        //Studio 1: 1 StudioDetails
        modelBuilder.Entity<Studio>()
            .HasOne(s => s.StudioDetails)
            .WithOne(sd => sd.Studio)
            .HasForeignKey<StudioDetails>(sd => sd.StudioId)
            .OnDelete(DeleteBehavior.Restrict);
        
        //Studio 1: Many movie
        modelBuilder.Entity<Movie>()
            .HasOne(m => m.Studio)
            .WithMany(s => s.Movies)
            .HasForeignKey(m => m.StudioId)
            .OnDelete(DeleteBehavior.Restrict);
        
        // Movie Many: Many actor
        modelBuilder.Entity<Movie>()
            .HasMany(m => m.Actors)
            .WithMany(a => a.Movies)
            .UsingEntity<Dictionary <string, object>>(
                "MovieActors",
                right => right
                .HasOne<Actor>()
                .WithMany()
                .HasForeignKey("ActorId")
                .OnDelete(DeleteBehavior.Cascade),
                
                left => left
                        .HasOne<Movie>()
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade),

                join =>
                {
                    join.HasKey("MovieId", "ActorId");
                });
        
    }
    
}