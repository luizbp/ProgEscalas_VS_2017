namespace ProgEscalas.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbEscala : DbContext
    {
        public dbEscala()
            : base("name=dbEscala")
        {
        }

        public virtual DbSet<alunos> alunos { get; set; }
        public virtual DbSet<config> config { get; set; }
        public virtual DbSet<escala> escala { get; set; }
        public virtual DbSet<sal_aluno> sal_aluno { get; set; }
        public virtual DbSet<salas> salas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<alunos>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<alunos>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<alunos>()
                .HasMany(e => e.sal_aluno)
                .WithOptional(e => e.alunos)
                .HasForeignKey(e => e.IDALUNO);

            modelBuilder.Entity<sal_aluno>()
                .HasMany(e => e.escala)
                .WithOptional(e => e.sal_aluno)
                .HasForeignKey(e => e.IDSAL_ALUNO);

            modelBuilder.Entity<salas>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<salas>()
                .HasMany(e => e.sal_aluno)
                .WithOptional(e => e.salas)
                .HasForeignKey(e => e.IDSALA);
        }
    }
}
