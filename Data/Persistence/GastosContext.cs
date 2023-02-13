using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Data.Persistence;

public partial class GastosContext : DbContext
{
    public GastosContext()
    {
    }

    public GastosContext(DbContextOptions<GastosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CatConcepto> CatConceptos { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=sqleduardo.database.windows.net;Database=DB_Gastos;User Id=Eduardo;Password=Edu26362668");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CatConcepto>(entity =>
        {
            entity.ToTable("Cat_Concepto");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(600)
                .IsUnicode(false);
            entity.Property(e => e.Valor)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.ToTable("Compra");

            entity.Property(e => e.CatConceptoId).HasColumnName("Cat_Concepto_Id");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Imagen).IsUnicode(false);
            entity.Property(e => e.Total).HasColumnType("money");

            entity.HasOne(d => d.CatConcepto).WithMany(p => p.Compras)
                .HasForeignKey(d => d.CatConceptoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Compra_Cat_Concepto");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
