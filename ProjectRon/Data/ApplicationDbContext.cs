using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectRon.Data;

namespace ProjectRon.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>

{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<QRCode> QRCodes { get; set; } = default!;
    public virtual DbSet<NewTable> NewTables { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<QRCode>()
            .Property(s => s.Updated)
            .HasDefaultValue(DateTime.Now);

        builder.Entity<NewTable>(entity =>
        {
            entity.HasKey(e => e.Column1);

            entity.ToTable("NewTable");

            entity.Property(e => e.Column1)
                .ValueGeneratedNever()
                .HasColumnName("column_1");
            entity.Property(e => e.Column2)
                .HasMaxLength(50)
                .HasColumnName("column_2");
            entity.Property(e => e.Column3).HasColumnName("column_3");
        });
    }
}

