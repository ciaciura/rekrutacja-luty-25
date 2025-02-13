using System;
using Microsoft.EntityFrameworkCore;
using rekrutacja_luty_25.Models;
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
