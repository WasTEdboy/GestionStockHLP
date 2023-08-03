using System;
using System.Collections.Generic;
using GestionStockHLP.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionStockHLP.Repository;

public partial class GestionStockDbContext : DbContext
{
    public GestionStockDbContext()
    {
    }

    public GestionStockDbContext(DbContextOptions<GestionStockDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Emplacement> Emplacements { get; set; }

    public virtual DbSet<Inventaire> Inventaires { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Magasin> Magasins { get; set; }

    public virtual DbSet<Magasinier> Magasiniers { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }
    public virtual DbSet<Locationfinder> LocationFinders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-N092F3Q\\SQLEXPRESS;Initial Catalog=GestionStock;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Emplacement>(entity =>
        {
            entity.HasKey(e => e.IdEmplacement).HasName("PK__Emplacem__ADFE360826C786CE");

            entity.HasOne(d => d.IdMagasinNavigation).WithMany(p => p.Emplacements).HasConstraintName("FK__Emplaceme__IdMag__571DF1D5");
        });

        modelBuilder.Entity<Inventaire>(entity =>
        {
            entity.HasKey(e => e.IdInventaire).HasName("PK__Inventai__17E496A7E96977F1");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PK__Location__E7FEA497FA4C86F2");

            entity.Property(e => e.Date).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.CodeArticleNavigation).WithMany(p => p.Locations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Location_Stock");

            entity.HasOne(d => d.IdEmplacementNavigation).WithMany(p => p.Locations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Location_Emplacement");

            entity.HasOne(d => d.IdInventaireNavigation).WithMany(p => p.Locations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Location_Inventaire");

            entity.HasOne(d => d.IdMagasinierNavigation).WithMany(p => p.Locations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Location_Magasinier");

            entity.HasOne(d => d.IdMagazinNavigation).WithMany(p => p.Locations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Location_Magasin");
        });

        modelBuilder.Entity<Magasin>(entity =>
        {
            entity.HasKey(e => e.IdMagasin).HasName("PK__Magasin__0CE760D0D639EA21");
        });

        modelBuilder.Entity<Magasinier>(entity =>
        {
            entity.HasKey(e => e.IdMagasinier).HasName("PK__Magasini__69638116D95AF0CE");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => e.CodeArticle).HasName("PK__Stock__32384FB051279E96");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
