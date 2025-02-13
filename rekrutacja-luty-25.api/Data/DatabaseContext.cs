using System;
using Microsoft.EntityFrameworkCore;
using rekrutacja_luty_25.commons.Models;
using rekrutacja_luty_25.commons.Models.Dictionaries;
namespace rekrutacja_luty_25.Data;

public partial class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Authority> Authorities { get; set; }
    public virtual DbSet<AuthorityEmail> AuthorityEmails { get; set; }
    public virtual DbSet<AuthorityPhoneNumber> AuthorityPhoneNumbers { get; set; }
    public virtual DbSet<DictCountry> DictCountry { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Authority>(p =>
        {
            p.ToTable("authority");

            p.HasComment("Organy wysylajace mandaty");

            p.HasOne<DictCountry>(p => p.Country)
            .WithMany(p => p.Authorities)
            .HasForeignKey(p => p.CountrySymbol);

            p.HasKey(k => k.Id);

            p.HasIndex(o => new { o.Symbol, o.Name, o.Street, o.PostalCode, o.City })
            .IsFullText(true)
            .HasDatabaseName("FT_authority");

            p.HasIndex(o => new { o.Symbol })
            .IsFullText(true)
            .HasDatabaseName("FT_authority_symbol");

            p.Property(p => p.Id)
            .ValueGeneratedOnAdd();

            p.Property(p => p.Id)
            .IsRequired()
            .HasColumnName("id");

            p.Property(p => p.Symbol)
            .HasMaxLength(128)
            .HasColumnName("symbol");

            p.Property(p => p.Name)
            .HasMaxLength(256)
            .HasColumnName("name");

            p.Property(p => p.Street)
            .IsRequired()
            .HasMaxLength(256)
            .HasColumnName("street");

            p.Property(p => p.Comment)
            .IsRequired()
            .HasMaxLength(256)
            .HasColumnName("comment");

            p.Property(p => p.AcceptsEmail)
            .IsRequired()
            .HasColumnType("bit(1)")
            .HasColumnName("accepts_email");

            p.Property(p => p.Active)
            .IsRequired()
            .HasColumnType("bit(1)")
            .HasColumnName("active");

            p.Property(p => p.PostalCode)
            .IsRequired()
            .HasMaxLength(256)
            .HasColumnName("postal_code");

            p.Property(p => p.City)
            .IsRequired()
            .HasMaxLength(256)
            .HasColumnName("city");

            p.Property(p => p.CountrySymbol)
            .IsRequired()
            .HasColumnName("id_country");
        });
        modelBuilder.Entity<AuthorityEmail>(p =>
        {
            p.ToTable("authority_email");

            p.HasComment("Adresy email organu");

            p.HasOne<Authority>(p => p.Authority)
            .WithMany(p => p.Emails)
            .HasForeignKey(p => p.AuthorityId);

            p.HasKey(k => k.Id);

            p.HasIndex(i => new { i.Email })
            .IsFullText(true)
            .HasDatabaseName("FT_authority_email_email");

            p.Property(p => p.Id)
            .ValueGeneratedOnAdd();

            p.Property(p => p.Id)
            .IsRequired()
            .HasColumnName("id");

            p.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(256)
            .HasColumnName("email");

            p.Property(p => p.Active)
            .IsRequired()
            .HasColumnType("bit")
            .HasColumnName("active");

            p.Property(p => p.AuthorityId)
            .IsRequired()
            .HasColumnName("authority");

        });

        modelBuilder.Entity<AuthorityPhoneNumber>(p =>
        {
            p.ToTable("authority_phone");

            p.HasComment("Numery Telefony organu");

            p.HasOne<Authority>(p => p.Authority)
            .WithMany(p => p.PhoneNumbers)
            .HasForeignKey(p => p.AuthorityId);

            p.HasKey(k => k.Id);

            p.Property(p => p.Id)
            .ValueGeneratedOnAdd();

            p.Property(p => p.Id)
            .IsRequired()
            .HasColumnName("id");

            p.Property(p => p.Number)
            .IsRequired()
            .HasMaxLength(256)
            .HasColumnName("number");

            p.Property(p => p.Active)
            .IsRequired()
            .HasColumnType("bit")
            .HasColumnName("active");

            p.Property(p => p.AuthorityId)
            .IsRequired()
            .HasColumnName("authority");

        });
        modelBuilder.Entity<DictCountry>(p =>
        {
            p.ToTable("dict_country");

            p.HasComment("Slownik krajow");

            p.HasKey(k => k.Symbol);

            p.Ignore(p => p.Id);
            p.Property(p => p.Active)
            .HasColumnType("bit")
            .HasColumnName("active");


            p.Property(p => p.Symbol)
            .HasMaxLength(128)
            .IsRequired()
            .HasColumnName("symbol");

            p.Property(p => p.Name)
            .HasMaxLength(256)
            .HasColumnName("name");

            p.Ignore(p => p.Description);

        });

    }
}
