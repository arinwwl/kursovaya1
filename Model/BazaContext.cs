using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KursSolodkaya.Model;

public partial class BazaContext : DbContext
{
    public BazaContext()
    {
    }

    public BazaContext(DbContextOptions<BazaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Dealer> Dealers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=Baza.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contract>(entity =>
        {
            entity.ToTable("contracts");

            entity.Property(e => e.ContractId)
                .ValueGeneratedNever()
                .HasColumnName("contract_id");
            entity.Property(e => e.CarMake).HasColumnName("car_make");
            entity.Property(e => e.CarPhoto).HasColumnName("car_photo");
            entity.Property(e => e.Commission).HasColumnName("commission");
            entity.Property(e => e.ContractDate).HasColumnName("contract_date");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.DealerId).HasColumnName("dealer_id");
            entity.Property(e => e.Mileage).HasColumnName("mileage");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.ReleaseDate).HasColumnName("release_date");
            entity.Property(e => e.SaleDate).HasColumnName("sale_date");
            entity.Property(e => e.SalePrice).HasColumnName("sale_price");

            entity.HasOne(d => d.Customer).WithMany(p => p.Contracts).HasForeignKey(d => d.CustomerId);

            entity.HasOne(d => d.Dealer).WithMany(p => p.Contracts).HasForeignKey(d => d.DealerId);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("customers");

            entity.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("customer_id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.MiddleName).HasColumnName("middle_name");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
        });

        modelBuilder.Entity<Dealer>(entity =>
        {
            entity.ToTable("dealers");

            entity.Property(e => e.DealerId).HasColumnName("dealer_id");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.HomeAddres).HasColumnName("home_addres");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.MiddleName).HasColumnName("middle_name");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
            entity.Property(e => e.Photo).HasColumnName("photo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
