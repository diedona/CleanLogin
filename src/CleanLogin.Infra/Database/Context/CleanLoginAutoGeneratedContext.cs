// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CleanLogin.Infra.Database.Entities;

#nullable disable

namespace CleanLogin.Infra.Database.Context
{
    public partial class CleanLoginAutoGeneratedContext : DbContext
    {
        public CleanLoginAutoGeneratedContext()
        {
        }

        public CleanLoginAutoGeneratedContext(DbContextOptions<CleanLoginAutoGeneratedContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.NomeDeUsuario)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(800);

                entity.Property(e => e.Sobrenome)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}