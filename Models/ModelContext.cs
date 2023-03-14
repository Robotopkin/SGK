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

    public virtual DbSet<BelovskayagresMin> BelovskayagresMins { get; set; }

    public virtual DbSet<Gtesnovokuznetckay> Gtesnovokuznetckays { get; set; }

    public virtual DbSet<GtesnovokuznetckayMin> GtesnovokuznetckayMins { get; set; }

    public virtual DbSet<Kemgre> Kemgres { get; set; }

    public virtual DbSet<KemgresMin> KemgresMins { get; set; }

    public virtual DbSet<Kemtec> Kemtecs { get; set; }

    public virtual DbSet<KemtecMin> KemtecMins { get; set; }

    public virtual DbSet<Kuznetckaytec> Kuznetckaytecs { get; set; }

    public virtual DbSet<KuznetckaytecMin> KuznetckaytecMins { get; set; }

    public virtual DbSet<Newkemtec> Newkemtecs { get; set; }

    public virtual DbSet<NewkemtecMin> NewkemtecMins { get; set; }

    public virtual DbSet<Tomusinskaygre> Tomusinskaygres { get; set; }

    public virtual DbSet<TomusinskaygresMin> TomusinskaygresMins { get; set; }

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

        modelBuilder.Entity<BelovskayagresMin>(entity =>
        {
            entity.HasKey(e => e.Time1970).HasName("BELOVSKAYAGRES_MIN_PK");

            entity.ToTable("BELOVSKAYAGRES_MIN");

            entity.Property(e => e.Time1970)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIME1970");
            entity.Property(e => e.State)
                .HasPrecision(6)
                .HasColumnName("STATE");
            entity.Property(e => e.Val).HasColumnName("VAL");
        });

        modelBuilder.Entity<Gtesnovokuznetckay>(entity =>
        {
            entity.HasKey(e => e.Time1970).HasName("GTESNOVOKUZNETCKAY_PK");

            entity.ToTable("GTESNOVOKUZNETCKAY");

            entity.Property(e => e.Time1970)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIME1970");
            entity.Property(e => e.State)
                .HasPrecision(6)
                .HasColumnName("STATE");
            entity.Property(e => e.Val).HasColumnName("VAL");
        });

        modelBuilder.Entity<GtesnovokuznetckayMin>(entity =>
        {
            entity.HasKey(e => e.Time1970).HasName("GTESNOVOKUZNETCKAY_MIN_PK");

            entity.ToTable("GTESNOVOKUZNETCKAY_MIN");

            entity.Property(e => e.Time1970)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIME1970");
            entity.Property(e => e.State)
                .HasPrecision(6)
                .HasColumnName("STATE");
            entity.Property(e => e.Val).HasColumnName("VAL");
        });

        modelBuilder.Entity<Kemgre>(entity =>
        {
            entity.HasKey(e => e.Time1970).HasName("KEMGRES_PK");

            entity.ToTable("KEMGRES");

            entity.Property(e => e.Time1970)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIME1970");
            entity.Property(e => e.State)
                .HasPrecision(6)
                .HasColumnName("STATE");
            entity.Property(e => e.Val).HasColumnName("VAL");
        });

        modelBuilder.Entity<KemgresMin>(entity =>
        {
            entity.HasKey(e => e.Time1970).HasName("KEMGRES_MIN_PK");

            entity.ToTable("KEMGRES_MIN");

            entity.Property(e => e.Time1970)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIME1970");
            entity.Property(e => e.State)
                .HasPrecision(6)
                .HasColumnName("STATE");
            entity.Property(e => e.Val).HasColumnName("VAL");
        });

        modelBuilder.Entity<Kemtec>(entity =>
        {
            entity.HasKey(e => e.Time1970).HasName("KEMTEC_PK");

            entity.ToTable("KEMTEC");

            entity.Property(e => e.Time1970)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIME1970");
            entity.Property(e => e.State)
                .HasPrecision(6)
                .HasColumnName("STATE");
            entity.Property(e => e.Val).HasColumnName("VAL");
        });

        modelBuilder.Entity<KemtecMin>(entity =>
        {
            entity.HasKey(e => e.Time1970).HasName("KEMTEC_MIN_PK");

            entity.ToTable("KEMTEC_MIN");

            entity.Property(e => e.Time1970)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIME1970");
            entity.Property(e => e.State)
                .HasPrecision(6)
                .HasColumnName("STATE");
            entity.Property(e => e.Val).HasColumnName("VAL");
        });

        modelBuilder.Entity<Kuznetckaytec>(entity =>
        {
            entity.HasKey(e => e.Time1970).HasName("KUZNETCKAYTEC_PK");

            entity.ToTable("KUZNETCKAYTEC");

            entity.Property(e => e.Time1970)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIME1970");
            entity.Property(e => e.State)
                .HasPrecision(6)
                .HasColumnName("STATE");
            entity.Property(e => e.Val).HasColumnName("VAL");
        });

        modelBuilder.Entity<KuznetckaytecMin>(entity =>
        {
            entity.HasKey(e => e.Time1970).HasName("KUZNETCKAYTEC_MIN_PK");

            entity.ToTable("KUZNETCKAYTEC_MIN");

            entity.Property(e => e.Time1970)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIME1970");
            entity.Property(e => e.State)
                .HasPrecision(6)
                .HasColumnName("STATE");
            entity.Property(e => e.Val).HasColumnName("VAL");
        });

        modelBuilder.Entity<Newkemtec>(entity =>
        {
            entity.HasKey(e => e.Time1970).HasName("NEWKEMTEC_PK");

            entity.ToTable("NEWKEMTEC");

            entity.Property(e => e.Time1970)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIME1970");
            entity.Property(e => e.State)
                .HasPrecision(6)
                .HasColumnName("STATE");
            entity.Property(e => e.Val).HasColumnName("VAL");
        });

        modelBuilder.Entity<NewkemtecMin>(entity =>
        {
            entity.HasKey(e => e.Time1970).HasName("NEWKEMTEC_MIN_PK");

            entity.ToTable("NEWKEMTEC_MIN");

            entity.Property(e => e.Time1970)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIME1970");
            entity.Property(e => e.State)
                .HasPrecision(6)
                .HasColumnName("STATE");
            entity.Property(e => e.Val).HasColumnName("VAL");
        });

        modelBuilder.Entity<Tomusinskaygre>(entity =>
        {
            entity.HasKey(e => e.Time1970).HasName("TOMUSINSKAYGRES_PK");

            entity.ToTable("TOMUSINSKAYGRES");

            entity.Property(e => e.Time1970)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIME1970");
            entity.Property(e => e.State)
                .HasPrecision(6)
                .HasColumnName("STATE");
            entity.Property(e => e.Val).HasColumnName("VAL");
        });

        modelBuilder.Entity<TomusinskaygresMin>(entity =>
        {
            entity.HasKey(e => e.Time1970).HasName("TOMUSINSKAYGRES_MIN_PK");

            entity.ToTable("TOMUSINSKAYGRES_MIN");

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
