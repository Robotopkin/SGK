using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SGK.Models;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Belovskayagre> Belovskayagres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<Belovskayagre>(entity =>
        {
            entity.HasKey(e => e.Time1970).HasName("BELOVSKAYAGRES_PK");

            entity.ToTable("BELOVSKAYAGRES");

            entity.Property(e => e.Time1970)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIME1970");
            entity.Property(e => e.State)
                .HasPrecision(6)
                .HasColumnName("STATE");
            entity.Property(e => e.Val).HasColumnName("VAL");
        });
        modelBuilder.HasSequence("LOGMNR_DIDS$");
        modelBuilder.HasSequence("LOGMNR_EVOLVE_SEQ$");
        modelBuilder.HasSequence("LOGMNR_SEQ$");
        modelBuilder.HasSequence("LOGMNR_UIDS$").IsCyclic();
        modelBuilder.HasSequence("MVIEW$_ADVSEQ_GENERIC");
        modelBuilder.HasSequence("MVIEW$_ADVSEQ_ID");
        modelBuilder.HasSequence("ROLLING_EVENT_SEQ$");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
