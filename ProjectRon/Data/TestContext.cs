using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjectRon.Data;

public partial class TestContext : DbContext
{
    public TestContext()
    {
    }

    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NewTable> NewTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:ddomengeaux.database.windows.net,1433;Initial Catalog=test;Persist Security Info=False;User ID=tester;Password=usNG#vbNQ-QcGY2k;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NewTable>(entity =>
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

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
