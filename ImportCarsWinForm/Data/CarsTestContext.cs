using ImportCarsWinForm.Models;
using Microsoft.EntityFrameworkCore;

namespace ImportCarsWinForm.Data;

public partial class CarsTestContext : DbContext
{
    public CarsTestContext()
    {
    }

    public CarsTestContext(DbContextOptions<CarsTestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Feedback> Feedbacks { get; set; }

    public virtual DbSet<FeedbackType> FeedbackTypes { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString: Constants.ConnectionStrings.CarsTest);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.Property(e => e.CarNumber).HasMaxLength(20);
            entity.Property(e => e.Color).HasMaxLength(10);
            entity.Property(e => e.Model).HasMaxLength(50);
        });

        modelBuilder.Entity<Feedback>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FeedBack");

            entity.ToTable("Feedback");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comment).HasMaxLength(150);
            entity.Property(e => e.FeedbackType).HasMaxLength(5);
        });

        modelBuilder.Entity<FeedbackType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FeedbackType");

            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(5);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.Comment).HasMaxLength(500);
            entity.Property(e => e.CompanyHp).HasMaxLength(10);
            entity.Property(e => e.CompanyName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
