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

    public virtual DbSet<Citation> Citations { get; set; }

    public virtual DbSet<ServiceBarber> ServiceBarbers { get; set; }

    public virtual DbSet<ServiceUser> ServiceUsers { get; set; }

    public virtual DbSet<UserBarber> UserBarbers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=barberShop;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Barber>(entity =>
        {
            entity.HasKey(e => e.IdBarber).HasName("PK__barber__2E4F587104CB2472");

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
            entity.Property(e => e.MotherLastName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("motherLastName");
            entity.Property(e => e.NameBarber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nameBarber");
        });

        modelBuilder.Entity<Citation>(entity =>
        {
            entity.HasKey(e => e.IdCitation).HasName("PK__citation__027614C9BCEB6C4C");

            entity.ToTable("citation");

            entity.Property(e => e.IdCitation).HasColumnName("idCitation");
            entity.Property(e => e.DateCitation).HasColumnName("dateCitation");
            entity.Property(e => e.HourCitation).HasColumnName("hourCitation");
        });

        modelBuilder.Entity<ServiceBarber>(entity =>
        {
            entity.HasKey(e => e.IdService).HasName("PK__serviceB__0E3EA45BBE72EE0F");

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
            entity.HasKey(e => e.IdServiceUser).HasName("PK__serviceU__4B46C89FF286CB64");

            entity.ToTable("serviceUser");

            entity.Property(e => e.IdServiceUser).HasColumnName("idServiceUser");
            entity.Property(e => e.IdBarber).HasColumnName("idBarber");
            entity.Property(e => e.IdCitation).HasColumnName("idCitation");
            entity.Property(e => e.IdService).HasColumnName("idService");
            entity.Property(e => e.IdUser).HasColumnName("idUser");

            entity.HasOne(d => d.IdBarberNavigation).WithMany(p => p.ServiceUsers)
                .HasForeignKey(d => d.IdBarber)
                .HasConstraintName("FK__serviceUs__idBar__5165187F");

            entity.HasOne(d => d.IdCitationNavigation).WithMany(p => p.ServiceUsers)
                .HasForeignKey(d => d.IdCitation)
                .HasConstraintName("FK__serviceUs__idCit__5441852A");

            entity.HasOne(d => d.IdServiceNavigation).WithMany(p => p.ServiceUsers)
                .HasForeignKey(d => d.IdService)
                .HasConstraintName("FK__serviceUs__idSer__534D60F1");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.ServiceUsers)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK__serviceUs__idUse__52593CB8");
        });

        modelBuilder.Entity<UserBarber>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PK__userBarb__3717C982FF1138E8");

            entity.ToTable("userBarber");

            entity.Property(e => e.IdUser).HasColumnName("idUser");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("contactNumber");
            entity.Property(e => e.FatherLastName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fatherLastName");
            entity.Property(e => e.MotherLastName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("motherLastName");
            entity.Property(e => e.NameUser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nameUser");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
