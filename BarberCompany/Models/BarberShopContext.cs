using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BarberCompany.Models;

public partial class BarberShopContext : DbContext
{
    public BarberShopContext()
    {
    }

    public BarberShopContext(DbContextOptions<BarberShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Barber> Barbers { get; set; }

    public virtual DbSet<BarberShop> BarberShops { get; set; }

    public virtual DbSet<Citation> Citations { get; set; }

    public virtual DbSet<ServiceBarber> ServiceBarbers { get; set; }

    public virtual DbSet<ServiceUser> ServiceUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=barberShop;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Barber>(entity =>
        {
            entity.HasKey(e => e.IdBarber).HasName("PK__barber__2E4F5871D74AB701");

            entity.ToTable("barber");

            entity.Property(e => e.IdBarber).HasColumnName("idBarber");
            entity.Property(e => e.AvailabilityBarber).HasColumnName("availabilityBarber");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("contactNumber");
            entity.Property(e => e.FatherLastName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fatherLastName");
            entity.Property(e => e.IdBarberShop).HasColumnName("idBarberShop");
            entity.Property(e => e.MotherLastName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("motherLastName");
            entity.Property(e => e.NameBarber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nameBarber");

            entity.HasOne(d => d.IdBarberShopNavigation).WithMany(p => p.Barbers)
                .HasForeignKey(d => d.IdBarberShop)
                .HasConstraintName("FK__barber__idBarber__398D8EEE");
        });

        modelBuilder.Entity<BarberShop>(entity =>
        {
            entity.HasKey(e => e.IdBarberShop).HasName("PK__barberSh__EE362D869F22C78E");

            entity.ToTable("barberShop");

            entity.Property(e => e.IdBarberShop).HasColumnName("idBarberShop");
            entity.Property(e => e.Address)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.AddressNumber).HasColumnName("addressNumber");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.NameBarber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nameBarber");
        });

        modelBuilder.Entity<Citation>(entity =>
        {
            entity.HasKey(e => e.IdCitation).HasName("PK__citation__027614C9A559295B");

            entity.ToTable("citation");

            entity.Property(e => e.IdCitation).HasColumnName("idCitation");
            entity.Property(e => e.DateCitation).HasColumnName("dateCitation");
            entity.Property(e => e.HourCitation).HasColumnName("hourCitation");
            entity.Property(e => e.NameUser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nameUser");
        });

        modelBuilder.Entity<ServiceBarber>(entity =>
        {
            entity.HasKey(e => e.IdService).HasName("PK__serviceB__0E3EA45B8B48AC7E");

            entity.ToTable("serviceBarber");

            entity.Property(e => e.IdService).HasColumnName("idService");
            entity.Property(e => e.DescriptionService)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descriptionService");
            entity.Property(e => e.NameService)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nameService");
            entity.Property(e => e.ServiceCost)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("serviceCost");
        });

        modelBuilder.Entity<ServiceUser>(entity =>
        {
            entity.HasKey(e => e.IdServiceUser).HasName("PK__serviceU__4B46C89FD86516B9");

            entity.ToTable("serviceUser");

            entity.Property(e => e.IdServiceUser).HasColumnName("idServiceUser");
            entity.Property(e => e.IdBarber).HasColumnName("idBarber");
            entity.Property(e => e.IdBarberShop).HasColumnName("idBarberShop");
            entity.Property(e => e.IdCitation).HasColumnName("idCitation");
            entity.Property(e => e.IdService).HasColumnName("idService");

            entity.HasOne(d => d.IdBarberNavigation).WithMany(p => p.ServiceUsers)
                .HasForeignKey(d => d.IdBarber)
                .HasConstraintName("FK__serviceUs__idBar__412EB0B6");

            entity.HasOne(d => d.IdBarberShopNavigation).WithMany(p => p.ServiceUsers)
                .HasForeignKey(d => d.IdBarberShop)
                .HasConstraintName("FK__serviceUs__idBar__403A8C7D");

            entity.HasOne(d => d.IdCitationNavigation).WithMany(p => p.ServiceUsers)
                .HasForeignKey(d => d.IdCitation)
                .HasConstraintName("FK__serviceUs__idCit__4316F928");

            entity.HasOne(d => d.IdServiceNavigation).WithMany(p => p.ServiceUsers)
                .HasForeignKey(d => d.IdService)
                .HasConstraintName("FK__serviceUs__idSer__4222D4EF");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
