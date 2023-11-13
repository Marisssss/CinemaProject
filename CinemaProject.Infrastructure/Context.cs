using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CinemaProject.Infrastructure
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<CinemaEntity> Cinema { get; set; }
        public virtual DbSet<ClientEntity> Client { get; set; }
        public virtual DbSet<EmployeeEntity> Employee { get; set; }
        public virtual DbSet<HallEntity> Hall { get; set; }
        public virtual DbSet<MovieEntity> Movie { get; set; }
        public virtual DbSet<PostEntity> Post { get; set; }
        public virtual DbSet<SessionEntity> Session { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientEntity>()
                .HasMany(e => e.Session)
                .WithMany(e => e.Client)
                .Map(m => m.ToTable("Client_Session").MapLeftKey("ID_client").MapRightKey("ID_session"));

            modelBuilder.Entity<HallEntity>()
                .HasMany(e => e.Session)
                .WithRequired(e => e.Hall)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MovieEntity>()
                .Property(e => e.Rating)
                .HasPrecision(53, 0);

            modelBuilder.Entity<MovieEntity>()
                .HasMany(e => e.Session)
                .WithRequired(e => e.Movie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PostEntity>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.Post)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SessionEntity>()
                .Property(e => e.Session_end_time)
                .HasPrecision(53, 0);
        }
    }
}
