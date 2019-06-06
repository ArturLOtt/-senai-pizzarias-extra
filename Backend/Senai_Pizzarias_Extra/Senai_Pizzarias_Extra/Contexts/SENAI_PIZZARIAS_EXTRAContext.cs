using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Senai_Pizzarias_Extra.Domains
{
    public partial class SENAI_PIZZARIAS_EXTRAContext : DbContext
    {
        public SENAI_PIZZARIAS_EXTRAContext()
        {
        }

        public SENAI_PIZZARIAS_EXTRAContext(DbContextOptions<SENAI_PIZZARIAS_EXTRAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pizzarias> Pizzarias { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SqlExpress;Initial Catalog=SENAI_PIZZARIAS_EXTRA;User Id=sa;pwd=132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizzarias>(entity =>
            {
                entity.ToTable("PIZZARIAS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Categoria).HasColumnName("CATEGORIA");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasColumnName("ENDERECO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Isvegan).HasColumnName("ISVEGAN");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TelefoneComercial)
                    .IsRequired()
                    .HasColumnName("TELEFONE_COMERCIAL")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("USUARIO");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__USUARIO__161CF724A033E2E4")
                    .IsUnique();

                entity.HasIndex(e => e.Senha)
                    .HasName("UQ__USUARIO__C8727D65A164EF6B")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("SENHA")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });
        }
    }
}
